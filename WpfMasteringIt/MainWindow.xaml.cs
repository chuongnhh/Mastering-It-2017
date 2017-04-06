using BusinessLogic;
using DatabaseObject.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfMasteringIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

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
                //ResetQuestionContent(maTroChoi);
                // laays thoi gian
                try
                {
                    Game game = (new BLGame()).Get(gameId);

                    // khai báo lại nhé ^^
                    int timeCount = game.GameTime;
                    txbTime.Text = timeCount.ToString();
                    //timeMax = timeCount;
                }
                catch (Exception)
                {
                    //timeCount = 0;
                    //timeMax = 0;
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

        private void txtScoreDoiSo1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
        }
    }
}
