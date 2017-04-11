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
using System.Windows.Shapes;

namespace WpfMasteringIt
{
    /// <summary>
    /// Interaction logic for frmSummaryScore.xaml
    /// </summary>
    public partial class frmSummaryScore : Window
    {
        private Guid levelId;

        public frmSummaryScore(Guid levelId)
        {
            InitializeComponent();
            this.levelId = levelId;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var team = (new BLTeam()).GetByLevel(levelId);

            List<SummaryScore> lstSummaryScore = new List<SummaryScore>();

            foreach (var item in team)
            {
                //int scoreNumber = item.Scores.Sum(x => x.ScoreNumber);
                int scoreNumber = (new BLScore()).GetByTeam(item.Id).Sum(x => x.ScoreNumber);
                lstSummaryScore.Add(new SummaryScore
                {
                    TeamName = item.TeamName,
                    ScoreNumber = scoreNumber
                });
            }

            lstSummaryScore = lstSummaryScore.OrderByDescending(x => x.ScoreNumber).ToList();

            try
            {
                txbDoiSo1.Text = lstSummaryScore[0].TeamName;
                txbDoi1.Text = lstSummaryScore[0].ScoreNumber.ToString();

            }
            catch { }

            try
            {
                txbDoiSo2.Text = lstSummaryScore[1].TeamName;
                txbDoi2.Text = lstSummaryScore[1].ScoreNumber.ToString();

            }
            catch { }

            try
            {
                txbDoiSo3.Text = lstSummaryScore[2].TeamName;
                txbDoi3.Text = lstSummaryScore[2].ScoreNumber.ToString();
            }
            catch { }

            try
            {
                txbDoiSo4.Text = lstSummaryScore[3].TeamName;
                txbDoi4.Text = lstSummaryScore[3].ScoreNumber.ToString();
            }
            catch { }

            try
            {
                txbDoiSo5.Text = lstSummaryScore[4].TeamName;
                txbDoi5.Text = lstSummaryScore[4].ScoreNumber.ToString();
            }
            catch { }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
