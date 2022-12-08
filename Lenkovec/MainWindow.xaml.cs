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

namespace Lenkovec
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LenkovetssEntities _current = new LenkovetssEntities();
        List<Преподаватель> prepodavatel = LenkovetssEntities.GetContext().Преподаватель.ToList();
        List<Должность> dolsnost = LenkovetssEntities.GetContext().Должность.ToList();
        List<УчёнаяСтепень> uchenastepen = LenkovetssEntities.GetContext().УчёнаяСтепень.ToList();
        List<Предмет> predmet = LenkovetssEntities.GetContext().Предмет.ToList();
        List<Нагрузка> nagruzka = LenkovetssEntities.GetContext().Нагрузка.ToList();
        List<Группа> grup = LenkovetssEntities.GetContext().Группа.ToList();
        List<ALLS> alls = LenkovetssEntities.GetContext().ALLS.ToList();

        int count;
        public MainWindow()
        {
            DataContext = _current;
            InitializeComponent();




        }
        private void UpdateT()
        {
            //var c = NewEntities.GetContext().ALLS.ToList();

            //c = c.Where(p => p.Наименования.ToLower().Contains(MyTxt.Text.ToLower())).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //One.ItemsSource = machina;x
            var res =
             from i in prepodavatel
             join dol in dolsnost
               on i.КодДолжности equals dol.IdДолжности into prepod_dol
             join uch in uchenastepen
             on i.КодУчёнойСтепени equals uch.IdУчёнойСтепени into prepod_uch
             
             from sub in prepod_dol.DefaultIfEmpty()
             from sub2 in prepod_uch.DefaultIfEmpty()
             select new { i.Фамилия, i.Стаж, i.Телефон, Должность = sub?.НаименованиеДолжности, УчёнаяСтепень = sub2?.НаименованиеУчёнойСтепени };
            One.ItemsSource = res;
            count = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //One.ItemsSource = marsrut;
            var res =
              from i in dolsnost
              select new { i.НаименованиеДолжности, i.Оклад };
            One.ItemsSource = res;
            count = 2;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //One.ItemsSource = voditeli;
            var res =
               from i in uchenastepen
               select new { i.НаименованиеУчёнойСтепени };
            One.ItemsSource = res;
            count = 3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //One.ItemsSource = vidirabor;
            var res =
               from i in predmet
               select new { i.Название, i.Часы };
            One.ItemsSource = res;
            count = 4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //One.ItemsSource = kategoria;
            var res =
             from i in nagruzka
             join dol in predmet
               on i.КодПредмета equals dol.IdПредмета into prepod_dol
             join uch in prepodavatel
             on i.КодПреподавателя equals uch.IdПреподавателя into prepod_uch

             from sub in prepod_dol.DefaultIfEmpty()
             from sub2 in prepod_uch.DefaultIfEmpty()
             select new { i.Колвочасов, i.Колвопредметов, Предмет = sub?.Название, Преподаватель = sub2?.Фамилия };
            One.ItemsSource = res;
            count = 5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //One.ItemsSource = prodelannaiarabota;
            var res =
             from i in grup
             join dol in nagruzka
               on i.КодНагрузки equals dol.IdНагрузки into prepod_dol
             

             from sub in prepod_dol.DefaultIfEmpty()
             select new { i.NumГруппы, Нагрузка = sub?.Колвочасов};
            One.ItemsSource = res;
            count = 6;

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            One.ItemsSource = alls;

        }


        


        private void SearchEntity(string s)
        {
            var db = new LenkovetssEntities();
            try
            {
                var clients = db.ALLS;
                List<ALLS> d = new List<ALLS>();
                foreach (var client in clients)
                {
                    if (client.Учеба.StartsWith(s) || client.Стаж.ToString().StartsWith(s) || client.Телефон.ToString().StartsWith(s) || client.НаименованиеДолжности.ToString().StartsWith(s) || client.Оклад.ToString().StartsWith(s) || client.НаименованиеУчёнойСтепени.ToString().StartsWith(s) || client.Колвочасов.ToString().StartsWith(s) || client.Колвопредметов.ToString().StartsWith(s) || client.Название.ToString().StartsWith(s) || client.Часы.ToString().StartsWith(s) || client.NumГруппы.StartsWith(s) )
                    {
                        d.Add(client);
                    }

                    client.Учеба.OrderBy(p => p);
                }
                One.ItemsSource = d;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MyTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            //(One.C as DataTable).DefaultView.RowFilter = $"Премии LIKE '%{MyTxt}%'";

            char[] k = MyTxt.Text.ToCharArray();
            string s;

            try
            {
                s = MyTxt.Text;
                SearchEntity(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

            string soort = sort.Text;

            switch (soort)
            {
                case "Учеба":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Учеба);
                    break;
                case "Стаж":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Стаж);
                    break;
                case "Телефон":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Телефон);
                    break;
                case "НаименованиеДолжности":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.НаименованиеДолжности);
                    break;
                case "Оклад":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Оклад);
                    break;
                case "НаименованиеУчёнойСтепени":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.НаименованиеУчёнойСтепени);
                    break;
                case "Колвочасов":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Колвочасов);
                    break;
                case "Колвопредметов":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Колвопредметов);
                    break;
                case "Название":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Название);
                    break;
                case "Часы":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.Часы);
                    break;
                case "NumГруппы":
                    One.ItemsSource = new LenkovetssEntities().ALLS.ToList().OrderByDescending(x => x.NumГруппы);
                    break;
              

            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
           
            Operation operation = new Operation();
            operation.ShowDialog();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
