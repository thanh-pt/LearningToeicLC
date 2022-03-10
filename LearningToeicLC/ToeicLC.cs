using LearningToeicLC.Object;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LearningToeicLC
{
    public partial class ToeicLC : Form
    {
        private const int PLAY_FULL = 0;
        private const int PLAY_SESSION = 1;

        private Point startPoint = new Point(-3, 0);
        private Point endPoint = new Point(-3, 0);
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private int playMode = PLAY_FULL;
        private int currentIndex = -1;
        private List<Session> listSessionItems;
        private ToeicLCProject lcProject;
        private string currentProjectFilePath = "";
        private bool firstTimeOpen = true;
        public ToeicLC()
        {
            InitializeComponent();
            showWelcomePage();
            // Clear setup in ui
            progressInside.Width = 0;
            progressInsideSession.Width = 0;
            pinStart.Location = startPoint;
            pinEnd.Location = endPoint;
            // Configuration Player
            wplayer.PlayStateChange += Player_PlayStateChange;
            wplayer.MediaError += Player_MediaError;
        }

        #region utility function
        private void showApplication()
        {
            foreach (var lbl in Controls.OfType<Control>())
                lbl.Show();
        }

        private void showWelcomePage()
        {
            foreach (var lbl in Controls.OfType<Control>())
                lbl.Hide();
            btnCreateProject.Show();
            btnOpenProject.Show();
        }
        private void reloadListItem()
        {
            listBoxSavedItem.Items.Clear();
            foreach (var session in listSessionItems)
            {
                listBoxSavedItem.Items.Add(session.Name + ": " + session.StartTimeString + " - " + session.EndTimeString);
            }
        }

        private double convertStringTime2Double(string strTime)
        {
            double result = -1.0;
            try
            {
                string[] timing = strTime.Split(':');
                result = 60 * (double)Int32.Parse(timing[0]) + Int32.Parse(timing[1]);
            }
            catch (Exception)
            {
            }
            return result;
        }

        private void changeControlFontStyle(Control tb, FontStyle style)
        {
            if (tb != null)
            {
                tb.Font = new Font(tb.Font, style);
            }
        }
        #endregion

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Console.WriteLine("Stopped");
                btnPlayPause.Text = "Play";
            }
            else if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsPaused)
            {
                btnPlayPause.Text = "Play";
                //tickerTimer.Enabled = false;
            }
            else if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                tickerTimer.Enabled = true;
                btnPlayPause.Text = "Pause";
                if (firstTimeOpen == true)
                {
                    firstTimeOpen = false;
                    wplayer.controls.pause();
                }
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse Mp3 Files";
            openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lcProject.AudioMp3FilePath = openFileDialog.FileName;
                txtMediaFileName.Text = openFileDialog.FileName;
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (lcProject.AudioMp3FilePath == "")
            {
                MessageBox.Show("Please select media file");
                return;
            }

            if (wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wplayer.controls.pause();
            }
            else
            {
                wplayer.controls.play();
            }
        }

        private void btnSeekup_Click(object sender, EventArgs e)
        {
            wplayer.controls.currentPosition += (double)numSeekDuration.Value;
        }

        private void btnSeekdown_Click(object sender, EventArgs e)
        {
            wplayer.controls.currentPosition -= (double)numSeekDuration.Value;
        }

        private void txtMediaFileName_TextChanged(object sender, EventArgs e)
        {
            wplayer.URL = lcProject.AudioMp3FilePath;
            firstTimeOpen = true;
        }

        private void tickerTimer_Tick(object sender, EventArgs e)
        {
            txtTiming.Text = wplayer.controls.currentPositionString + "/" + wplayer.controls.currentItem.durationString;
            progressInside.Width = (int)(wplayer.controls.currentPosition / wplayer.controls.currentItem.duration * progressBorder.Width);
            if (playMode == PLAY_SESSION)
            {
                if (currentIndex == -1)
                {
                    return;
                }
                progressInsideSession.Width = (int)((wplayer.controls.currentPosition - listSessionItems[currentIndex].StartTime) / (listSessionItems[currentIndex].EndTime - listSessionItems[currentIndex].StartTime) * progressBorderSession.Width);
                if (wplayer.controls.currentPosition > listSessionItems[currentIndex].EndTime)
                {
                    wplayer.controls.pause();
                }
            }
        }

        #region ProgressBar clicked
        private void handleClickToProgressFullBar()
        {
            if (playMode != PLAY_FULL)
            {
                return;
            }
            Point point = progressBorder.PointToClient(Cursor.Position);
            progressInside.Width = point.X;
            wplayer.controls.currentPosition = (double)point.X / progressBorder.Width * wplayer.controls.currentItem.duration;
        }
        private void progressBorder_Click(object sender, EventArgs e)
        {
            handleClickToProgressFullBar();
        }

        private void progressInside_Click(object sender, EventArgs e)
        {
            handleClickToProgressFullBar();
        }

        private void pinStart_Click(object sender, EventArgs e)
        {
            handleClickToProgressFullBar();
        }

        private void pinEnd_Click(object sender, EventArgs e)
        {
            handleClickToProgressFullBar();
        }

        private void handleClickToProgressSessionBar()
        {
            if (playMode != PLAY_SESSION)
            {
                return;
            }
            Point point = progressBorderSession.PointToClient(Cursor.Position);
            wplayer.controls.currentPosition = (double)point.X / progressBorderSession.Width * (listSessionItems[currentIndex].EndTime - listSessionItems[currentIndex].StartTime) + listSessionItems[currentIndex].StartTime;
        }

        private void progressBorderSession_Click(object sender, EventArgs e)
        {
            handleClickToProgressSessionBar();
        }

        private void progressInsideSession_Click(object sender, EventArgs e)
        {
            handleClickToProgressSessionBar();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            double tempStartTime = convertStringTime2Double(txtNewStartTime.Text);
            double tempEndTime = convertStringTime2Double(txtNewEndTime.Text);
            if (tempStartTime < 0 || tempEndTime < 0)
            {
                MessageBox.Show("Invalid session input");
                return;
            }

            Session session = new Session();
            session.Name = txtNewName.Text;
            session.StartTimeString = txtNewStartTime.Text;
            session.EndTimeString = txtNewEndTime.Text;
            session.StartTime = convertStringTime2Double(session.StartTimeString);
            session.EndTime = convertStringTime2Double(session.EndTimeString);
            listSessionItems.Add(session);
            reloadListItem();
        }

        private void btnMarkStart_Click(object sender, EventArgs e)
        {
            txtNewStartTime.Text = wplayer.controls.currentPositionString;
            startPoint.X = progressInside.Width;
            pinStart.Location = startPoint;
        }

        private void btnMarkEnd_Click(object sender, EventArgs e)
        {
            txtNewEndTime.Text = wplayer.controls.currentPositionString;
            endPoint.X = progressInside.Width;
            pinEnd.Location = endPoint;
        }

        private void listBoxSavedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSavedItem.SelectedIndex < 0)
            {
                return;
            }
            currentIndex = listBoxSavedItem.SelectedIndex;
            txtCurrentStart.Text = listSessionItems[currentIndex].StartTimeString;
            txtCurrentEnd.Text = listSessionItems[currentIndex].EndTimeString;
            txtCurrentName.Text = listSessionItems[currentIndex].Name;
            txtNote.Text = listSessionItems[currentIndex].Note;
        }

        private void btnPlaySelected_Click(object sender, EventArgs e)
        {
            wplayer.controls.currentPosition = listSessionItems[currentIndex].StartTime;
            playMode = PLAY_SESSION;
            wplayer.controls.play();
            changeControlFontStyle(btnPlaySelected, FontStyle.Bold);
            changeControlFontStyle(btnFullPlay, FontStyle.Regular);
        }

        private void btnFullPlay_Click(object sender, EventArgs e)
        {
            playMode = PLAY_FULL;
            changeControlFontStyle(btnPlaySelected, FontStyle.Regular);
            changeControlFontStyle(btnFullPlay, FontStyle.Bold);
        }

        private void txtCurrentStart_TextChanged(object sender, EventArgs e)
        {
            if (currentIndex == -1)
            {
                return;
            }
            if (txtCurrentStart.Text != listSessionItems[currentIndex].StartTimeString)
            {
                changeControlFontStyle(txtCurrentStart, FontStyle.Bold);
                return;
            }

            changeControlFontStyle(txtCurrentStart, FontStyle.Regular);
        }

        private void txtCurrentEnd_TextChanged(object sender, EventArgs e)
        {
            if (currentIndex == -1)
            {
                return;
            }
            if (txtCurrentEnd.Text != listSessionItems[currentIndex].EndTimeString)
            {
                changeControlFontStyle(txtCurrentEnd, FontStyle.Bold);
                return;
            }

            changeControlFontStyle(txtCurrentEnd, FontStyle.Regular);
        }

        private void txtCurrentName_TextChanged(object sender, EventArgs e)
        {
            if (currentIndex == -1)
            {
                return;
            }
            if (txtCurrentName.Text != listSessionItems[currentIndex].Name)
            {
                changeControlFontStyle(txtCurrentName, FontStyle.Bold);
                return;
            }

            changeControlFontStyle(txtCurrentName, FontStyle.Regular);
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            if (txtCurrentName.Font.Bold || txtCurrentStart.Font.Bold || txtCurrentEnd.Font.Bold)
            {
                double tempStartTime = convertStringTime2Double(txtCurrentStart.Text);
                double tempEndTime = convertStringTime2Double(txtCurrentEnd.Text);
                if (tempStartTime < 0 || tempEndTime < 0)
                {
                    MessageBox.Show("Invalid session input");
                    return;
                }
                if (currentIndex == -1)
                {
                    MessageBox.Show("Selected item empty");
                    return;
                }
                listSessionItems[currentIndex].Name = txtCurrentName.Text;
                listSessionItems[currentIndex].StartTimeString = txtCurrentStart.Text;
                listSessionItems[currentIndex].EndTimeString = txtCurrentEnd.Text;
                listSessionItems[currentIndex].StartTime = tempStartTime;
                listSessionItems[currentIndex].EndTime = tempEndTime;
                reloadListItem();
                listBoxSavedItem.SelectedIndex = currentIndex;
            }
        }

        private void btnJsonGenerate_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(lcProject);
            File.WriteAllText(currentProjectFilePath, json);
        }

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse Toeic LC Project Files";
            openFileDialog.Filter = ".lcprj files (*.lcprj)|*.lcprj";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentProjectFilePath = openFileDialog.FileName;
                string json = File.ReadAllText(currentProjectFilePath);
                lcProject = JsonConvert.DeserializeObject<ToeicLCProject>(json);
                listSessionItems = lcProject.SessionItems;
                reloadListItem();
                this.Text = "Learning Toeic LC - " + currentProjectFilePath;
                txtMediaFileName.Text = lcProject.AudioMp3FilePath;
                showApplication();
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Create Toeic LC Project File";
            saveFileDialog.Filter = ".lcprj files (*.lcprj)|*.lcprj";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentProjectFilePath = saveFileDialog.FileName;
                lcProject = new ToeicLCProject();
                listSessionItems = lcProject.SessionItems;
                this.Text = "Learning Toeic LC - " + currentProjectFilePath;
                showApplication();
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (currentIndex == -1)
            {
                return;
            }
            if (txtNote.Text != listSessionItems[currentIndex].Note)
            {
                listSessionItems[currentIndex].Note = txtNote.Text;
            }
        }
    }
}
