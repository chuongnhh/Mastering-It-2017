using BusinessLogic;
using DatabaseObject.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfMasteringIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Question> lstQuestion;
        private int indexquestion = 0;
        private SoundPlayer sound = new SoundPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            }
            else this.WindowState = WindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                cmbLevel.ItemsSource = (new BLLevel()).GetAll();
                cmbLevel.DisplayMemberPath = "LevelName";
                cmbLevel.SelectedValuePath = "Id";
                cmbLevel.SelectedIndex = 0;
                txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Guid LevelId = Guid.Parse(cmbLevel.SelectedValue.ToString());

                // Tro Choi
                cmbGame.ItemsSource = (new BLGame()).GetByLevel(LevelId);
                cmbGame.DisplayMemberPath = "GameName";
                cmbGame.SelectedValuePath = "Id";
                cmbGame.SelectedIndex = 0;

                List<Team> lstTeam = (new BLTeam()).GetByLevel(LevelId);

                // cap nhap ten doi len form
                try
                {
                    lblDoiSo1.Content = lstTeam[0].TeamName;
                    lblDoiSo1.Tag = lstTeam[0].Id;

                    lblDoiSo1.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo1.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo1.Visibility = Visibility.Visible;
                    txtScoreDoiSo1.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo1.Content = "";

                    lblDoiSo1.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo1.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo1.Visibility = Visibility.Hidden;
                    txtScoreDoiSo1.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo2.Content = lstTeam[1].TeamName;
                    lblDoiSo2.Tag = lstTeam[1].Id;

                    lblDoiSo2.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo2.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo2.Visibility = Visibility.Visible;
                    txtScoreDoiSo2.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo2.Content = "";

                    lblDoiSo2.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo2.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo2.Visibility = Visibility.Hidden;
                    txtScoreDoiSo2.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo3.Content = lstTeam[2].TeamName;
                    lblDoiSo3.Tag = lstTeam[2].Id;

                    lblDoiSo3.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo3.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo3.Visibility = Visibility.Visible;
                    txtScoreDoiSo3.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo3.Content = "";

                    lblDoiSo3.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo3.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo3.Visibility = Visibility.Hidden;
                    txtScoreDoiSo3.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo4.Content = lstTeam[3].TeamName;
                    lblDoiSo4.Tag = lstTeam[3].Id;

                    lblDoiSo4.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo4.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo4.Visibility = Visibility.Visible;
                    txtScoreDoiSo4.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo4.Content = "";

                    lblDoiSo4.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo4.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo4.Visibility = Visibility.Hidden;
                    txtScoreDoiSo4.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo5.Content = lstTeam[4].TeamName;
                    lblDoiSo5.Tag = lstTeam[4].Id;

                    lblDoiSo5.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo5.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo5.Visibility = Visibility.Visible;
                    txtScoreDoiSo5.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo5.Content = "";

                    lblDoiSo5.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo5.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo5.Visibility = Visibility.Hidden;
                    txtScoreDoiSo5.Visibility = Visibility.Hidden;
                }
                cmbGame_SelectionChanged(null, null);
            }
            catch (Exception)
            {
                // neu khong co du lieu
            }
        }

        private void cmbGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Guid gameId = Guid.Parse(cmbGame.SelectedValue.ToString());
                ResetQuestionContent(gameId);

                // laays thoi gian
                try
                {
                    Game game = (new BLGame()).Get(gameId);

                    // khai báo lại nhé ^^
                    int timeCount = game.GameTime;
                    //txbTime.Text = timeCount.ToString("mm':'ss");
                    timeMax = timeCount;
                }
                catch (Exception)
                {
                    timeCount = 0;
                    timeMax = 0;
                    // khong có tro choi
                }

                Guid levelId = Guid.Parse(cmbLevel.SelectedValue.ToString());
                // cap nhat diem cho cac doi len form
                try
                {
                    Guid teamId = (Guid)lblDoiSo1.Tag;

                    Score score = (new BLScore()).Get(teamId, levelId, gameId);
                    txtScoreDoiSo1.Text = score.ScoreNumber.ToString();
                }
                catch (Exception)
                {
                    txtScoreDoiSo1.Text = "0";
                }

                try
                {
                    Guid teamId = (Guid)lblDoiSo2.Tag;

                    Score score = (new BLScore()).Get(teamId, levelId, gameId);
                    txtScoreDoiSo2.Text = score.ScoreNumber.ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo2.Text = "0";
                }

                try
                {
                    Guid teamId = (Guid)lblDoiSo3.Tag;

                    Score score = (new BLScore()).Get(teamId, levelId, gameId);
                    txtScoreDoiSo3.Text = score.ScoreNumber.ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo3.Text = "0";
                }

                try
                {
                    Guid teamId = (Guid)lblDoiSo4.Tag;

                    Score score = (new BLScore()).Get(teamId, levelId, gameId);
                    txtScoreDoiSo4.Text = score.ScoreNumber.ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo4.Text = "0";
                }

                try
                {
                    Guid teamId = (Guid)lblDoiSo5.Tag;

                    Score score = (new BLScore()).Get(teamId, levelId, gameId);
                    txtScoreDoiSo5.Text = score.ScoreNumber.ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo5.Text = "0";
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
        }

        private void btnNextQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // so cau hoi
                int maxquestion = lstQuestion.Count();

                if (indexquestion < maxquestion)
                {
                    indexQuestion(++indexquestion);

                    prgTime.Maximum = timeMax;
                    prgTime.Value = timeCount = 0;
                    txbTime.Text = (TimeSpan.FromSeconds(timeMax)).ToString("mm':'ss");

                    btnAnswer.IsEnabled = false;

                    if (btnStartTime.IsEnabled == false)
                        btnStartTime.IsEnabled = true;
                    if (btnShowQuestion.IsEnabled == false)
                        btnShowQuestion.IsEnabled = true;
                    try
                    {
                        SoundPlay("../../../Music/Next.wav");
                        sound.Play();
                        played = false;
                    }
                    catch (Exception)
                    {
                    }
                    seen = false;
                }
            }
            catch (Exception)
            {
                txbTenCauHoi.Text = "";
                txbNoiDungCauHoi.Text = "";
                txbLuaChonA.Text = "";
                txbLuaChonB.Text = "";
                txbLuaChonC.Text = "";
                txbLuaChonD.Text = "";
                txbA.Text = "";
                txbB.Text = "";
                txbC.Text = "";
                txbD.Text = "";
                txbTime.Text = "</>";
                btnShowQuestion.IsEnabled = false;
                btnStartTime.IsEnabled = false;
            }
        }

        private void btnPreviewQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int maxquestion = lstQuestion.Count();

                if (indexquestion > 0)
                {
                    indexQuestion(--indexquestion);
                    prgTime.Maximum = timeMax;
                    prgTime.Value = timeCount = 0;
                    txbTime.Text = (TimeSpan.FromSeconds(timeMax)).ToString("mm':'ss");
                    btnAnswer.IsEnabled = false;

                    if (btnStartTime.IsEnabled == false)
                        btnStartTime.IsEnabled = true;
                    if (btnShowQuestion.IsEnabled == false)
                        btnShowQuestion.IsEnabled = true;

                    SoundPlay("../../../Music/Next.wav");
                    sound.Play();
                    played = false;
                    seen = false;
                }
            }
            catch (Exception)
            {

            }
        }

        DispatcherTimer dispatcherTimer;
        int timeCount = 0;// thoi gian dem
        int timeMax = 0;// thoi gian cua tro choi

        private void DispatcherTimer()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (timeCount >= timeMax)
            {
                btnStartTime.IsEnabled = true;
                dispatcherTimer.Stop();
                txbTime.Text = "Hết Giờ";
                sound.Stop();
                played = false;
                // bat cac button len sau khi het time
                IsEnableControl(true);
            }
            else
            {
                // Updating the Label which displays the current second
                timeCount = ++timeCount;
                txbTime.Text = (TimeSpan.FromSeconds(timeMax - timeCount)).ToString("mm':'ss");
                prgTime.Value = timeCount;
                int percent = Convert.ToInt32(0.7 * timeMax);
                if (timeCount <= percent)
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                else
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF6335"));
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        // Game
        private void IsEnableControl(bool value)
        {
            btnAnswer.IsEnabled = value;
            btnStartTime.IsEnabled = value;
            btnNextQuestion.IsEnabled = value;
            btnPreviewQuestion.IsEnabled = value;

            //
            btnPlusScoreDoiSo1.IsEnabled = value;
            btnPlusScoreDoiSo2.IsEnabled = value;
            btnPlusScoreDoiSo3.IsEnabled = value;
            btnPlusScoreDoiSo4.IsEnabled = value;
            btnPlusScoreDoiSo5.IsEnabled = value;


            btnMinusScoreDoiSo1.IsEnabled = value;
            btnMinusScoreDoiSo2.IsEnabled = value;
            btnMinusScoreDoiSo3.IsEnabled = value;
            btnMinusScoreDoiSo4.IsEnabled = value;
            btnMinusScoreDoiSo5.IsEnabled = value;

            txtScoreDoiSo1.IsEnabled = value;
            txtScoreDoiSo2.IsEnabled = value;
            txtScoreDoiSo3.IsEnabled = value;
            txtScoreDoiSo4.IsEnabled = value;
            txtScoreDoiSo5.IsEnabled = value;

            //
            cmbLevel.IsEnabled = value;
            cmbGame.IsEnabled = value;
            btnSummary.IsEnabled = value;
        }


        private void indexQuestion(int index)
        {
            try
            {
                txbTenCauHoi.Text = lstQuestion[index].QuestionLabel;
                txbNoiDungCauHoi.Text = lstQuestion[index].QuestionName;

                txbLuaChonA.Text = lstQuestion[index].Answers[0].AnswerName;
                txbLuaChonB.Text = lstQuestion[index].Answers[1].AnswerName;
                txbLuaChonC.Text = lstQuestion[index].Answers[2].AnswerName;
                txbLuaChonD.Text = lstQuestion[index].Answers[3].AnswerName;

                txbLuaChonA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                txbLuaChonB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                txbLuaChonC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                txbLuaChonD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                if (txbLuaChonA.Text == "") txbA.Text = "";
                else txbA.Text = "A. ";
                if (txbLuaChonB.Text == "") txbB.Text = "";
                else txbB.Text = "B. ";
                if (txbLuaChonC.Text == "") txbC.Text = "";
                else txbC.Text = "C. ";
                if (txbLuaChonD.Text == "") txbD.Text = "";
                else txbD.Text = "D. ";
            }
        }

        private void ResetQuestionContent(Guid gameId)
        {
            try
            {
                // lay du lieu Cau Hoi
                lstQuestion = lstQuestion = (new BLQuestion()).GetByGame(gameId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // neu khong cos du lieu
            }
            finally
            {
                txbTenCauHoi.Text = "";
                txbNoiDungCauHoi.Text = "";
                txbLuaChonA.Text = "";
                txbLuaChonB.Text = "";
                txbLuaChonC.Text = "";
                txbLuaChonD.Text = "";
                txbA.Text = "";
                txbB.Text = "";
                txbC.Text = "";
                txbD.Text = "";
                indexquestion = -1;
                btnAnswer.IsEnabled = false;
                btnStartTime.IsEnabled = false;
                btnShowQuestion.IsEnabled = false;
            }
        }

        public bool seen { get; set; }
        public bool seenAnswer { get; set; }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Answer answer = lstQuestion[indexquestion]
                    .Answers.Where(x => x.IsTrue == true)
                    .FirstOrDefault();

                if (answer == null) return;

                if (answer.AnswerLabel == "A")
                {
                    txbLuaChonA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                    txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                }
                if (answer.AnswerLabel == "B")
                {
                    txbLuaChonB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                    txbB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                }
                if (answer.AnswerLabel == "C")
                {
                    txbLuaChonC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                    txbC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                }
                if (answer.AnswerLabel == "D")
                {
                    txbLuaChonD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                    txbD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                }
                if (played == false)
                {
                    SoundPlay("../../../Music/Answer.wav");
                    sound.Play();
                    played = false;
                }
                seen = true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                // khong có cau hoi thì đâu có dáp án
            }
        }

        private bool played = false;
        private void SoundPlay(string soundLocation)
        {
            try
            {
                sound.SoundLocation = soundLocation;
                played = true;
            }
            catch (Exception)
            {
            }
        }

        private void btnStartTime_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //Guid questionId = lstQuestion[indexquestion].Id;

                //int maTroChoi = int.Parse(cmbGame.SelectedValue.ToString());
                try
                {
                    if (played == false && timeCount < timeMax)
                    {
                        SoundPlay("../../../Music/BackGroundSound.wav");
                        sound.PlayLooping();
                    }
                }
                catch { }

                DispatcherTimer();

                // tat cac control
                IsEnableControl(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSummary_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                (new frmSummaryScore(Guid.Parse(cmbLevel.SelectedValue.ToString()))).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy đội thi nào", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


      
        private void txtScoreDoiSo1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
        }

        private void txtScoreDoiSo2_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
        }

        private void txtScoreDoiSo3_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
        }

        private void txtScoreDoiSo4_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
        }

        private void txtScoreDoiSo5_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
        }

        private void txtScoreDoiSo1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                try
                {
                    Guid levelId = (Guid)cmbLevel.SelectedValue;
                    Guid gameId = (Guid)cmbGame.SelectedValue;
                    Guid teamId = (Guid)lblDoiSo1.Tag;
                    int scoreNumber = int.Parse(txtScoreDoiSo1.Text.Trim());

                    if ((new BLScore().Get(teamId, levelId, gameId)) == null)
                    {
                        (new BLScore()).Insert(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    else
                    {
                        (new BLScore()).Update(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtScoreDoiSo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    Guid levelId = (Guid)cmbLevel.SelectedValue;
                    Guid gameId = (Guid)cmbGame.SelectedValue;
                    Guid teamId = (Guid)lblDoiSo2.Tag;
                    int scoreNumber = int.Parse(txtScoreDoiSo2.Text.Trim());

                    if ((new BLScore().Get(teamId, levelId, gameId)) == null)
                    {
                        (new BLScore()).Insert(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    else
                    {
                        (new BLScore()).Update(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtScoreDoiSo3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    Guid levelId = (Guid)cmbLevel.SelectedValue;
                    Guid gameId = (Guid)cmbGame.SelectedValue;
                    Guid teamId = (Guid)lblDoiSo3.Tag;
                    int scoreNumber = int.Parse(txtScoreDoiSo3.Text.Trim());

                    if ((new BLScore().Get(teamId, levelId, gameId)) == null)
                    {
                        (new BLScore()).Insert(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    else
                    {
                        (new BLScore()).Update(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtScoreDoiSo4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    Guid levelId = (Guid)cmbLevel.SelectedValue;
                    Guid gameId = (Guid)cmbGame.SelectedValue;
                    Guid teamId = (Guid)lblDoiSo4.Tag;
                    int scoreNumber = int.Parse(txtScoreDoiSo4.Text.Trim());

                    if ((new BLScore().Get(teamId, levelId, gameId)) == null)
                    {
                        (new BLScore()).Insert(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    else
                    {
                        (new BLScore()).Update(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtScoreDoiSo5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    Guid levelId = (Guid)cmbLevel.SelectedValue;
                    Guid gameId = (Guid)cmbGame.SelectedValue;
                    Guid teamId = (Guid)lblDoiSo5.Tag;
                    int scoreNumber = int.Parse(txtScoreDoiSo5.Text.Trim());

                    if ((new BLScore().Get(teamId, levelId, gameId)) == null)
                    {
                        (new BLScore()).Insert(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    else
                    {
                        (new BLScore()).Update(new Score
                        {
                            LevelId = levelId,
                            TeamId = teamId,
                            GameId = gameId,
                            ScoreNumber = scoreNumber
                        });
                    }
                    txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
