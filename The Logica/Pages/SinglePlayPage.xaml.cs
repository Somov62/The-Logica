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

namespace The_Logica.Pages
{
    /// <summary>
    /// Логика взаимодействия для SinglePlayPage.xaml
    /// </summary>
    public partial class SinglePlayPage : Page
    {
        private Ellipse _selectedChip;
        private bool IsChipSelected = false;
        private int _currentRow = 12;
        private Dictionary<string, Ellipse> _chips;
        private Dictionary<string, Ellipse> _answerChips;
        private Dictionary<string, Border> _rowsArea;
        private Bot _bot;

        public SinglePlayPage()
        {
            InitializeComponent();
            this.Focus();
            _chips = new Dictionary<string, Ellipse>();
            _answerChips = new Dictionary<string, Ellipse>();
            _rowsArea = new Dictionary<string, Border>();
            #region Add_AnswerChips
            _answerChips.Add(nameof(answer1s0),  answer1s0);
            _answerChips.Add(nameof(answer1s1),  answer1s1);
            _answerChips.Add(nameof(answer1s2),  answer1s2);
            _answerChips.Add(nameof(answer1s3),  answer1s3);
            _answerChips.Add(nameof(answer1s4),  answer1s4);
            _answerChips.Add(nameof(answer2s0),  answer2s0);
            _answerChips.Add(nameof(answer2s1),  answer2s1);
            _answerChips.Add(nameof(answer2s2),  answer2s2);
            _answerChips.Add(nameof(answer2s3),  answer2s3);
            _answerChips.Add(nameof(answer2s4),  answer2s4);
            _answerChips.Add(nameof(answer3s0),  answer3s0);
            _answerChips.Add(nameof(answer3s1),  answer3s1);
            _answerChips.Add(nameof(answer3s2),  answer3s2);
            _answerChips.Add(nameof(answer3s3),  answer3s3);
            _answerChips.Add(nameof(answer3s4),  answer3s4);
            _answerChips.Add(nameof(answer4s0),  answer4s0);
            _answerChips.Add(nameof(answer4s1),  answer4s1);
            _answerChips.Add(nameof(answer4s2),  answer4s2);
            _answerChips.Add(nameof(answer4s3),  answer4s3);
            _answerChips.Add(nameof(answer4s4),  answer4s4);
            _answerChips.Add(nameof(answer5s0),  answer5s0);
            _answerChips.Add(nameof(answer5s1),  answer5s1);
            _answerChips.Add(nameof(answer5s2),  answer5s2);
            _answerChips.Add(nameof(answer5s3),  answer5s3);
            _answerChips.Add(nameof(answer5s4),  answer5s4);
            _answerChips.Add(nameof(answer6s0),  answer6s0);
            _answerChips.Add(nameof(answer6s1),  answer6s1);
            _answerChips.Add(nameof(answer6s2),  answer6s2);
            _answerChips.Add(nameof(answer6s3),  answer6s3);
            _answerChips.Add(nameof(answer6s4),  answer6s4);
            _answerChips.Add(nameof(answer7s0),  answer7s0);
            _answerChips.Add(nameof(answer7s1),  answer7s1);
            _answerChips.Add(nameof(answer7s2),  answer7s2);
            _answerChips.Add(nameof(answer7s3),  answer7s3);
            _answerChips.Add(nameof(answer7s4),  answer7s4);
            _answerChips.Add(nameof(answer8s0),  answer8s0);
            _answerChips.Add(nameof(answer8s1),  answer8s1);
            _answerChips.Add(nameof(answer8s2),  answer8s2);
            _answerChips.Add(nameof(answer8s3),  answer8s3);
            _answerChips.Add(nameof(answer8s4),  answer8s4);
            _answerChips.Add(nameof(answer9s0),  answer9s0);
            _answerChips.Add(nameof(answer9s1),  answer9s1);
            _answerChips.Add(nameof(answer9s2),  answer9s2);
            _answerChips.Add(nameof(answer9s3),  answer9s3);
            _answerChips.Add(nameof(answer9s4),  answer9s4);
            _answerChips.Add(nameof(answer10s0), answer10s0);
            _answerChips.Add(nameof(answer10s1), answer10s1);
            _answerChips.Add(nameof(answer10s2), answer10s2);
            _answerChips.Add(nameof(answer10s3), answer10s3);
            _answerChips.Add(nameof(answer10s4), answer10s4);
            _answerChips.Add(nameof(answer11s0), answer11s0);
            _answerChips.Add(nameof(answer11s1), answer11s1);
            _answerChips.Add(nameof(answer11s2), answer11s2);
            _answerChips.Add(nameof(answer11s3), answer11s3);
            _answerChips.Add(nameof(answer11s4), answer11s4);
            _answerChips.Add(nameof(answer12s0), answer12s0);
            _answerChips.Add(nameof(answer12s1), answer12s1);
            _answerChips.Add(nameof(answer12s2), answer12s2);
            _answerChips.Add(nameof(answer12s3), answer12s3);
            _answerChips.Add(nameof(answer12s4), answer12s4);
            #endregion
            #region Add_Chips
            _chips.Add(nameof(cell1d0), cell1d0);
            _chips.Add(nameof(cell1d1), cell1d1);
            _chips.Add(nameof(cell1d2), cell1d2);
            _chips.Add(nameof(cell1d3), cell1d3);
            _chips.Add(nameof(cell1d4), cell1d4);
            _chips.Add(nameof(cell2d0), cell2d0);
            _chips.Add(nameof(cell2d1), cell2d1);
            _chips.Add(nameof(cell2d2), cell2d2);
            _chips.Add(nameof(cell2d3), cell2d3);
            _chips.Add(nameof(cell2d4), cell2d4);
            _chips.Add(nameof(cell3d0), cell3d0);
            _chips.Add(nameof(cell3d1), cell3d1);
            _chips.Add(nameof(cell3d2), cell3d2);
            _chips.Add(nameof(cell3d3), cell3d3);
            _chips.Add(nameof(cell3d4), cell3d4);
            _chips.Add(nameof(cell4d0), cell4d0);
            _chips.Add(nameof(cell4d1), cell4d1);
            _chips.Add(nameof(cell4d2), cell4d2);
            _chips.Add(nameof(cell4d3), cell4d3);
            _chips.Add(nameof(cell4d4), cell4d4);
            _chips.Add(nameof(cell5d0), cell5d0);
            _chips.Add(nameof(cell5d1), cell5d1);
            _chips.Add(nameof(cell5d2), cell5d2);
            _chips.Add(nameof(cell5d3), cell5d3);
            _chips.Add(nameof(cell5d4), cell5d4);
            _chips.Add(nameof(cell6d0), cell6d0);
            _chips.Add(nameof(cell6d1), cell6d1);
            _chips.Add(nameof(cell6d2), cell6d2);
            _chips.Add(nameof(cell6d3), cell6d3);
            _chips.Add(nameof(cell6d4), cell6d4);
            _chips.Add(nameof(cell7d0), cell7d0);
            _chips.Add(nameof(cell7d1), cell7d1);
            _chips.Add(nameof(cell7d2), cell7d2);
            _chips.Add(nameof(cell7d3), cell7d3);
            _chips.Add(nameof(cell7d4), cell7d4);
            _chips.Add(nameof(cell8d0), cell8d0);
            _chips.Add(nameof(cell8d1), cell8d1);
            _chips.Add(nameof(cell8d2), cell8d2);
            _chips.Add(nameof(cell8d3), cell8d3);
            _chips.Add(nameof(cell8d4), cell8d4);
            _chips.Add(nameof(cell9d0), cell9d0);
            _chips.Add(nameof(cell9d1), cell9d1);
            _chips.Add(nameof(cell9d2), cell9d2);
            _chips.Add(nameof(cell9d3), cell9d3);
            _chips.Add(nameof(cell9d4), cell9d4);
            _chips.Add(nameof(cell10d0), cell10d0);
            _chips.Add(nameof(cell10d1), cell10d1);
            _chips.Add(nameof(cell10d2), cell10d2);
            _chips.Add(nameof(cell10d3), cell10d3);
            _chips.Add(nameof(cell10d4), cell10d4);
            _chips.Add(nameof(cell11d0), cell11d0);
            _chips.Add(nameof(cell11d1), cell11d1);
            _chips.Add(nameof(cell11d2), cell11d2);
            _chips.Add(nameof(cell11d3), cell11d3);
            _chips.Add(nameof(cell11d4), cell11d4);
            _chips.Add(nameof(cell12d0), cell12d0);
            _chips.Add(nameof(cell12d1), cell12d1);
            _chips.Add(nameof(cell12d2), cell12d2);
            _chips.Add(nameof(cell12d3), cell12d3);
            _chips.Add(nameof(cell12d4), cell12d4);
            #endregion
            #region Add_RowsAreas
            _rowsArea.Add(nameof(Row1Area), Row1Area);
            _rowsArea.Add(nameof(Row2Area), Row2Area);
            _rowsArea.Add(nameof(Row3Area), Row3Area);
            _rowsArea.Add(nameof(Row4Area), Row4Area);
            _rowsArea.Add(nameof(Row5Area), Row5Area);
            _rowsArea.Add(nameof(Row6Area), Row6Area);
            _rowsArea.Add(nameof(Row7Area), Row7Area);
            _rowsArea.Add(nameof(Row8Area), Row8Area);
            _rowsArea.Add(nameof(Row9Area), Row9Area);
            _rowsArea.Add(nameof(Row10Area), Row10Area);
            _rowsArea.Add(nameof(Row11Area), Row11Area);
            _rowsArea.Add(nameof(Row12Area), Row12Area);
            #endregion

            _bot = new Bot();
        }

        private void SelectChip_Click(object sender, RoutedEventArgs e)
        {
            if (IsChipSelected) _selectedChip.Stroke = (SolidColorBrush)App.Current.Resources["RedAccent"];
            _selectedChip = (Ellipse)sender;
            _selectedChip.Stroke = Brushes.White;
            IsChipSelected = true;
        }

        private void SetColor_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedChip == default) return;
            _selectedChip.Fill = ((Button)sender).Background;
            _selectedChip.Stroke = (SolidColorBrush)Application.Current.Resources["RedAccent"];
            _selectedChip.StrokeThickness = 3;
            IsChipSelected = false;
            btnSend.IsEnabled = true;
            for (int i = 0; i < 5; i++)
            {
                Ellipse chip = _chips[$"cell{_currentRow}d{i}"];
                if (chip.Fill == (SolidColorBrush)App.Current.Resources["Black"])
                {
                    btnSend.IsEnabled = false;
                    break;
                }
            }
        }

        private void SendToCheck_Click(object sender, RoutedEventArgs e)
        {
            btnSend.IsEnabled = false;
            Border row = _rowsArea[$"Row{_currentRow}Area"];
            row.IsHitTestVisible = false;
            List<int> attempt = new();
            for (int i = 0; i < 5; i++)
            {
                Ellipse chip = _chips[$"cell{_currentRow}d{i}"];
                SolidColorBrush brush = (SolidColorBrush)chip.Fill;
                attempt.Add(Colors.ListColors.TryGetKey(brush.Color));
            }

            List<int> response = _bot.CheckCode(attempt);
            response.RemixArray();
            for (int i = 0; i < response.Count; i++)
            {
                Ellipse chip = _answerChips[$"answer{_currentRow}s{i}"];
                Colors.ListColors.TryGetValue(response[i], out Color color);
                chip.Fill = new SolidColorBrush(color);
            }
            if (_bot.CheckWin(response))
            {
                Win();
                return;
            }
            

            _currentRow--;
            if (_currentRow == 0)
            {
                Fail();
                return;
            }
            if (_currentRow < 6) countTry.Foreground = Brushes.Red;
            countTry.Text = _currentRow.ToString();
            row = _rowsArea[$"Row{_currentRow}Area"];
            row.Visibility = Visibility.Visible;
            _selectedChip.Stroke = (SolidColorBrush)Application.Current.Resources["RedAccent"];
            _selectedChip = default;
            IsChipSelected = false;
        }

        private void Fail()
        {
            ShowEncryptedCode();
        }

        private void Win()
        {
            ShowEncryptedCode();
        }

        private void ShowEncryptedCode()
        {
            encryptedCodeCell1.Visibility = Visibility.Visible;
            Colors.ListColors.TryGetValue(_bot.Code[0], out Color color);
            encryptedCodeCell1.Fill = new SolidColorBrush(color);

            encryptedCodeCell2.Visibility = Visibility.Visible;
            Colors.ListColors.TryGetValue(_bot.Code[1], out  color);
            encryptedCodeCell2.Fill = new SolidColorBrush(color);

            encryptedCodeCell3.Visibility = Visibility.Visible;
            Colors.ListColors.TryGetValue(_bot.Code[2], out  color);
            encryptedCodeCell3.Fill = new SolidColorBrush(color);

            encryptedCodeCell4.Visibility = Visibility.Visible;
            Colors.ListColors.TryGetValue(_bot.Code[3], out  color);
            encryptedCodeCell4.Fill = new SolidColorBrush(color);

            encryptedCodeCell5.Visibility = Visibility.Visible;
            Colors.ListColors.TryGetValue(_bot.Code[4], out  color);
            encryptedCodeCell5.Fill = new SolidColorBrush(color);
        }

        private void ShowTip_Click(object sender, RoutedEventArgs e)
        {
            tip1.Visibility = Visibility.Visible;
            tip2.Visibility = Visibility.Visible;
            tip3.Visibility = Visibility.Visible;
            tip4.Visibility = Visibility.Visible;
            btnTip.Visibility = Visibility.Hidden;
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            tip1.Visibility = Visibility.Hidden;
            tip2.Visibility = Visibility.Hidden;
            tip3.Visibility = Visibility.Hidden;
            tip4.Visibility = Visibility.Hidden;
            btnTip.Visibility = Visibility.Visible;
        }

        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu());
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SinglePlayPage());
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            string cell;
            switch (e.Key)
            {
                case Key.D1:
                case Key.NumPad1:
                    cell = $"cell{_currentRow}d{0}";
                    break;
                case Key.D2:
                case Key.NumPad2:
                    cell = $"cell{_currentRow}d{1}";
                    break;
                case Key.D3:
                case Key.NumPad3:
                    cell = $"cell{_currentRow}d{2}";
                    break;
                case Key.D4:
                case Key.NumPad4:
                    cell = $"cell{_currentRow}d{3}";
                    break;
                case Key.D5:
                case Key.NumPad5:
                    cell = $"cell{_currentRow}d{4}";
                    break;
                default:
                    return;
            }
            if (IsChipSelected) _selectedChip.Stroke = (SolidColorBrush)App.Current.Resources["RedAccent"];
            _selectedChip = _chips[cell];
            _selectedChip.Stroke = Brushes.White;
            IsChipSelected = true;
        }
    }

    public static class ListExtension
    {
        public static void RemixArray(this List<int> code)
        {
            Random rnd = new Random();
            for (int i = 0; i < code.Count; i++)
            {
                int replaceIndex = rnd.Next(code.Count);
                int value = code[i];
                code[i] = code[replaceIndex];
                code[replaceIndex] = value;
            }
        }
    }
}
