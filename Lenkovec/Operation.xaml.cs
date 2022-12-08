using System.Numerics;
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


namespace Lenkovec
{
    /// <summary>
    /// Логика взаимодействия для Operation.xaml
    /// </summary>
    public partial class Operation : Window
    {
        public Operation()
        {
            InitializeComponent();
        }

        private void otchet_Click(object sender, RoutedEventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.ShowDialog();
        }
        int count = 100;
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            One.ItemsSource = LenkovetssEntities.GetContext().Предмет.ToList();
            count = 3;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            One.ItemsSource = LenkovetssEntities.GetContext().Преподаватель.ToList();
            count = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            One.ItemsSource = LenkovetssEntities.GetContext().Должность.ToList();
            count = 1;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            One.ItemsSource = LenkovetssEntities.GetContext().Нагрузка.ToList();
            count = 4;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            One.ItemsSource = LenkovetssEntities.GetContext().УчёнаяСтепень.ToList();
            count = 2;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            One.ItemsSource = LenkovetssEntities.GetContext().Группа.ToList();
            count = 5;
        }


        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            switch (count)
            {
                case 0:
                    var hotelsForRemoving = One.SelectedItems.Cast<Преподаватель>().ToList();
                    if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        try
                        {
                            LenkovetssEntities.GetContext().Преподаватель.RemoveRange(hotelsForRemoving);
                            LenkovetssEntities.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены!");
                            One.ItemsSource = LenkovetssEntities.GetContext().Преподаватель.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    break;
                case 1:
                    var hotelsForRemoving1 = One.SelectedItems.Cast<Должность>().ToList();
                    if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving1.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        try
                        {
                            LenkovetssEntities.GetContext().Должность.RemoveRange(hotelsForRemoving1);
                            LenkovetssEntities.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены!");
                            One.ItemsSource = LenkovetssEntities.GetContext().Должность.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    break;
                case 2:
                    var hotelsForRemoving2 = One.SelectedItems.Cast<УчёнаяСтепень>().ToList();
                    if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving2.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        try
                        {
                            LenkovetssEntities.GetContext().УчёнаяСтепень.RemoveRange(hotelsForRemoving2);
                            LenkovetssEntities.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены!");
                            One.ItemsSource = LenkovetssEntities.GetContext().УчёнаяСтепень.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    break;
                case 3:
                    var hotelsForRemoving3 = One.SelectedItems.Cast<Предмет>().ToList();
                    if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving3.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        try
                        {
                            LenkovetssEntities.GetContext().Предмет.RemoveRange(hotelsForRemoving3);
                            LenkovetssEntities.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены!");
                            One.ItemsSource = LenkovetssEntities.GetContext().Предмет.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    break;
                case 4:
                    var hotelsForRemoving4 = One.SelectedItems.Cast<Нагрузка>().ToList();
                    if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving4.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        try
                        {
                            LenkovetssEntities.GetContext().Нагрузка.RemoveRange(hotelsForRemoving4);
                            LenkovetssEntities.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены!");
                            One.ItemsSource = LenkovetssEntities.GetContext().Нагрузка.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    break;
                case 5:
                    var hotelsForRemoving5 = One.SelectedItems.Cast<Группа>().ToList();
                    if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving5.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        try
                        {
                            LenkovetssEntities.GetContext().Группа.RemoveRange(hotelsForRemoving5);
                            LenkovetssEntities.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены!");
                            One.ItemsSource = LenkovetssEntities.GetContext().Группа.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    break;
            }

        }
        LenkovetssEntities db = new LenkovetssEntities();
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            switch (count)
            {
                case 0:
                    var vod = db.Должность.Where(x => x.НаименованиеДолжности == koddols.Text).FirstOrDefault();
                    var vod2 = db.УчёнаяСтепень.Where(x => x.НаименованиеУчёнойСтепени == kodus.Text).FirstOrDefault();

                    Преподаватель преподаватель = new Преподаватель();
                    преподаватель.Имя = name.Text;
                    преподаватель.Фамилия = surname.Text;
                    преподаватель.Отчество = otchestvo.Text;
                    преподаватель.Стаж = Convert.ToInt32(staz.Text);
                    преподаватель.Телефон = telefon.Text;
                    преподаватель.КодДолжности = vod.IdДолжности;
                    преподаватель.КодУчёнойСтепени = vod2.IdУчёнойСтепени;
                    db.Преподаватель.Add(преподаватель);
                    db.SaveChanges();
                    One.ItemsSource = db.Преподаватель.ToList();
                    break;
                case 1:
                    Должность должность = new Должность();
                    должность.НаименованиеДолжности = naum.Text;
                    должность.Оклад = Convert.ToInt32(oklad.Text);
                   
                    db.Должность.Add(должность);
                    db.SaveChanges();
                    One.ItemsSource = db.Должность.ToList();
                    break;
                case 2:

                    УчёнаяСтепень учёная = new УчёнаяСтепень();
                    учёная.НаименованиеУчёнойСтепени = s.Text;
                    db.УчёнаяСтепень.Add(учёная);
                    db.SaveChanges();
                    One.ItemsSource = db.УчёнаяСтепень.ToList();
                    break;
                case 3:
                    Предмет предмет = new Предмет();
                    предмет.Название = nameeee.Text;
                    предмет.Часы = Convert.ToInt32(chas.Text);
                 
                    db.Предмет.Add(предмет);
                    db.SaveChanges();
                    One.ItemsSource = db.Предмет.ToList();
                    break;
                case 4:
                    var vo = db.Предмет.Where(x => x.Название == kodpred.Text).FirstOrDefault();
                    var vo2 = db.Преподаватель.Where(x => x.Фамилия == kodprepod.Text).FirstOrDefault();


                    Нагрузка нагрузка = new Нагрузка();
                    нагрузка.Колвочасов =  Convert.ToInt32(Ours.Text);
                    нагрузка.Колвопредметов = Convert.ToInt32(Pred.Text);
                    нагрузка.КодПредмета = vo.IdПредмета;
                    нагрузка.КодПреподавателя = vo2.IdПреподавателя;
                    db.Нагрузка.Add(нагрузка);
                    db.SaveChanges();
                    One.ItemsSource = db.Нагрузка.ToList();
                    break;
                case 5:

                    //NewEntities df = new NewEntities();



                    //var rabot = db.ВидыРабот.Where(x => x.Наименования == OneW.Text).FirstOrDefault();
                    //var voditeli = db.Водители.Where(x => x.Имя == TwoW.Text).FirstOrDefault();
                    //var machina = db.Машина.Where(x => x.Марка == ThreeW.Text).FirstOrDefault();
                    //var mars = db.Маршрут.Where(x => x.Название == FourW.Text).FirstOrDefault();

                    //ПроделаннаяРабота сделка = new ПроделаннаяРабота();
                    //сделка.Премии = Convert.ToInt32(premii.Text);
                    //сделка.Обьем = Convert.ToInt32(obiom.Text);
                    //сделка.ДатаНачала = Convert.ToDateTime(datanach.Text);
                    //сделка.ДатаКонца = Convert.ToDateTime(datakonc.Text);
                    //сделка.КодВидыРабот = rabot.IDВидыРабот;
                    //сделка.КодВодителя = voditeli.IDВодителя;
                    //сделка.КодМашины = machina.IDМашины;
                    //сделка.КодМаршрута = mars.IDМаршрута;

                    //df.ПроделаннаяРабота.Add(сделка);
                    //df.SaveChanges();
                    //One.ItemsSource = db.ПроделаннаяРабота.ToList();

                    //var mars = db.Нагрузка.Where(x => x.Колвочасов == Convert.ToInt32(kodnagruzki.Text)).FirstOrDefault();

                    Группа obect = new Группа();
                    obect.NumГруппы = numgroup.Text;
                    //obect.КодНагрузки = mars.IdНагрузки;
                    obect.КодНагрузки = 1;

                    db.Группа.Add(obect);
                    db.SaveChanges();
                    One.ItemsSource = db.Группа.ToList();
                    break;
            }
        }

        private void kodnagruzki_Loaded(object sender, RoutedEventArgs e)
        {
            using (LenkovetssEntities db = new LenkovetssEntities())
            {
                var list = db.Нагрузка.ToList();
                foreach (var item in list)
                    kodnagruzki.Items.Add(item.Колвочасов);
            }
        }

        private void koddols_Loaded(object sender, RoutedEventArgs e)
        {
            using (LenkovetssEntities db = new LenkovetssEntities())
            {
                var list = db.Должность.ToList();
                foreach (var item in list)
                    koddols.Items.Add(item.НаименованиеДолжности);
            }
        }

        private void kodus_Loaded(object sender, RoutedEventArgs e)
        {
            using (LenkovetssEntities db = new LenkovetssEntities())
            {
                var list = db.УчёнаяСтепень.ToList();
                foreach (var item in list)
                    kodus.Items.Add(item.НаименованиеУчёнойСтепени);
            }
        }

        private void kodpred_Loaded(object sender, RoutedEventArgs e)
        {
            using (LenkovetssEntities db = new LenkovetssEntities())
            {
                var list = db.Предмет.ToList();
                foreach (var item in list)
                    kodpred.Items.Add(item.Название);
            }
        }

        private void kodprepod_Loaded(object sender, RoutedEventArgs e)
        {
            using (LenkovetssEntities db = new LenkovetssEntities())
            {
                var list = db.Преподаватель.ToList();
                foreach (var item in list)
                    kodprepod.Items.Add(item.Фамилия);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Close();
            Operation operation = new Operation();
            operation.ShowDialog();

        }
    }
}
