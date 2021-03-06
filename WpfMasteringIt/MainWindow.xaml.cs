﻿using BusinessLogic;
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
            btnShowQuestion.Visibility = Visibility.Hidden;
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

                Guid gameId = Guid.Parse(cmbGame.SelectedValue.ToString());
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
                Guid LevelId = Guid.Parse(cmbLevel.SelectedValue.ToString());
                // cap nhat team
                List<Team> lstTeam = (new BLTeam()).GetByLevel(LevelId,gameId);

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
                // end capnhat team
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

                if (indexquestion < maxquestion - 1)
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
                        //SoundPlay("../../../Music/Next.wav");
                        //sound.Play();
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
                //txbTenCauHoi.Text = "";
                //txbNoiDungCauHoi.Text = "";
                //txbLuaChonA.Text = "";
                //txbLuaChonB.Text = "";
                //txbLuaChonC.Text = "";
                //txbLuaChonD.Text = "";
                //txbA.Text = "";
                //txbB.Text = "";
                //txbC.Text = "";
                //txbD.Text = "";
                //txbTime.Text = "</>";
                //btnShowQuestion.IsEnabled = false;
                //btnStartTime.IsEnabled = false;
            }
        }

        private void btnPreviewQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int maxquestion = lstQuestion.Count();

                if (indexquestion >= 0)
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

                    //SoundPlay("../../../Music/Next.wav");
                    //sound.Play();
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

                if (lstQuestion[index].QuestionName.Count() > 200)
                {
                    txbNoiDungCauHoi.FontSize = 30;
                }
                else
                {
                    txbNoiDungCauHoi.FontSize = 48;
                }
                if (lstQuestion[index].Answers.Count() > 1)
                {

                    txbLuaChonA.Text = lstQuestion[index].Answers[0].AnswerName;
                    txbA.Text = lstQuestion[index].Answers[0].AnswerLabel;

                    txbLuaChonB.Text = lstQuestion[index].Answers[1].AnswerName;
                    txbB.Text = lstQuestion[index].Answers[1].AnswerLabel;

                    txbLuaChonC.Text = lstQuestion[index].Answers[2].AnswerName;
                    txbC.Text = lstQuestion[index].Answers[2].AnswerLabel;

                    txbLuaChonD.Text = lstQuestion[index].Answers[3].AnswerName;
                    txbD.Text = lstQuestion[index].Answers[3].AnswerLabel;


                    txbLuaChonA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                    txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                    txbLuaChonB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                    txbB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                    txbLuaChonC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                    txbC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                    txbLuaChonD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                    txbD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                }
                else
                {
                    txbLuaChonA.Text = "";
                    txbLuaChonB.Text = "";
                    txbLuaChonC.Text = "";
                    txbLuaChonD.Text = "";
                    txbA.Text = "";
                    txbB.Text = "";
                    txbC.Text = "";
                    txbD.Text = "";
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
            finally
            {
                if (txbLuaChonA.Text == "") txbA.Text = "";
                //else txbA.Text = "A. ";

                if (txbLuaChonB.Text == "") txbB.Text = "";
                //else txbB.Text = "B. ";

                if (txbLuaChonC.Text == "") txbC.Text = "";
                //else txbC.Text = "C. ";

                if (txbLuaChonD.Text == "") txbD.Text = "";
                //else txbD.Text = "D. ";
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

                List<Answer> lst = lstQuestion[indexquestion].Answers.ToList();

                if (lst.Count() == 1)
                {
                    txbA.Text = lst[0].AnswerName;
                    txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                    //txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");

                    return;
                };

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
                        prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                        txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                        SoundPlay("mp3.wav");
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

        private void gridSystemControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.M && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Minimized;
                }
                else this.WindowState = WindowState.Maximized;
            }
            else if (e.Key == Key.X && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                this.Close();
            }
            else if (e.Key == Key.Left)
            {
                if (btnPreviewQuestion.IsEnabled == true)
                    btnPreviewQuestion_Click(null, null);
            }
            else if (e.Key == Key.Right)
            {
                //if (btnNextQuestion.IsEnabled == true)
                btnNextQuestion_Click(null, null);
            }
            else if (e.Key == Key.Up)
            {
                if (btnStartTime.IsEnabled == true)
                    btnStartTime_Click(null, null);
            }
            else if (e.Key == Key.P && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                if (dispatcherTimer.IsEnabled == true)
                {
                    dispatcherTimer.IsEnabled = false;
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF6335"));
                    txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF6335"));
                    sound.Stop();
                }
                else
                {
                    dispatcherTimer.IsEnabled = true;
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                    txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                    sound.Play();
                }
                //btnAnswer_Click(null, null);
            }
            else if (e.Key == Key.R && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                sound.Stop();
                dispatcherTimer.Stop();
                prgTime.Maximum = timeMax;
                prgTime.Value = timeCount = 0;
                txbTime.Text = (TimeSpan.FromSeconds(timeMax)).ToString("mm':'ss");
                played = false;
                seen = false;
                prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                IsEnableControl(true);
            }

            else if (e.Key == Key.Down && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                btnAnswer_Click(null, null);
            }
        }

        private void btnPlusScoreDoiSo1_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo1.Text.Trim());
            txtScoreDoiSo1.Text = (score + 10).ToString();

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

        private void btnMinusScoreDoiSo1_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo1.Text.Trim());
            txtScoreDoiSo1.Text = (score - 10).ToString();

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

        private void btnPlusScoreDoiSo2_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo2.Text.Trim());
            txtScoreDoiSo2.Text = (score + 10).ToString();

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

        private void btnMinusScoreDoiSo2_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo2.Text.Trim());
            txtScoreDoiSo2.Text = (score - 10).ToString();

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

        private void btnPlusScoreDoiSo3_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo3.Text.Trim());
            txtScoreDoiSo3.Text = (score + 10).ToString();

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

        private void btnMinusScoreDoiSo3_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo3.Text.Trim());
            txtScoreDoiSo3.Text = (score - 10).ToString();

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

        private void btnPlusScoreDoiSo4_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo4.Text.Trim());
            txtScoreDoiSo4.Text = (score + 10).ToString();

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

        private void btnMinusScoreDoiSo4_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo4.Text.Trim());
            txtScoreDoiSo4.Text = (score - 10).ToString();

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

        private void btnPlusScoreDoiSo5_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo5.Text.Trim());
            txtScoreDoiSo5.Text = (score + 10).ToString();

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

        private void btnMinusScoreDoiSo5_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScoreDoiSo5.Text.Trim());
            txtScoreDoiSo5.Text = (score - 10).ToString();

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
