using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtVivod.Clear();
            int[] Mas1 = txtVvod.Text.Split(' ').
            Where(x => !string.IsNullOrWhiteSpace(x)).
            Select(x => int.Parse(x)).ToArray();
            int l = Mas1.Count();
            int remainder = l % 5;
            int nChunks = 5;
            int totalLength = Mas1.Count();
            int chunkLength = (int)Math.Ceiling(totalLength / (double)nChunks);
            var parts = Enumerable.Range(5, remainder)
            .Select(i => Mas1.Skip(i * chunkLength)
            .Take(chunkLength)
            .ToList())
            .ToList();

            if (l <= 5)
            {
                int temp;
                for (var i = 0; i < Mas1.Length - 1; i++)
                {
                    for (var j = i + 1; j < Mas1.Length; j++)
                    {

                        if (Mas1[i] > Mas1[j])
                        {
                            temp = Mas1[i];
                            Mas1[i] = Mas1[j];
                            Mas1[j] = temp;
                        }
                    }
                }
                for (var i = 0; i < Mas1.Length; i++)
                {
                    txtVivod.Text += Mas1[i].ToString() + " ";
                }
            }
            if(l > 5 && l <= 10)
            {
                
                int[] ms1 = new int[5]; //первая половина массива
                int[] ms2 = new int[remainder]; //вторая половина массива
                for (int i = 0; i < 5; i++)
                {
                    ms1[i] = Mas1[i];
                    txtVivod.Text += ms1[i].ToString() + " ";
                    int del = 1;// номер элемента который надо удалить из массива
                    var query = Mas1.Where(n => Mas1.ElementAt(del) != n);
                }
                for (int i = 0; i < remainder; i++)
                {
                    
                    ms2[i] = query;
                    txtVivod2.Text += ms2[i].ToString() + " ";
                }


            }

            //int nChunks = 5;
            //int totalLength = Mas1.Count();
            //int chunkLength = (int)Math.Ceiling(totalLength / (double)nChunks);
            //var parts = Enumerable.Range(0, 5)
            //.Select(i => Mas1.Skip(i * chunkLength)
            //.Take(chunkLength)
            //.ToList())
            //.ToList();
            //int[] Mas2 =parts.ToArray();
            //List<Task> taskList = new List<Task>(); /*Сформировать пул задач что нужно дождаться*/
            //foreach (var item in parts)
            //{

            //    var task = new Task(new Action<object>(DoSomething), Mas1);
            //    task.Start();
            //    taskList.Add(task);
            //}
            //Task.WaitAll(taskList.ToArray());/*Ждем всех*/
            //void DoSomething(object state)
            //{
            //    var part = (int[])state;
            //    int temp;
            //    for (var i = 0; i < Mas1.Length - 1; i++)
            //    {
            //        for (var j = i + 1; j < Mas1.Length; j++)
            //        {

            //            if (Mas1[i] > Mas1[j])
            //            {
            //                temp = Mas1[i];
            //                Mas1[i] = Mas1[j];
            //                Mas1[j] = temp;
            //            }
            //        }
            //    }  
            //}
            //for (var i = 0; i < Mas1.Length; i++)
            //{
            //    txtVivod.Text += Mas1[i].ToString() + " ";
            //}




            //int temp;
            //for (var i = 0; i < Mas1.Length - 1; i++)
            //{
            //    for (var j = i + 1; j < Mas1.Length; j++)
            //    {

            //        if (Mas1[i] > Mas1[j])
            //        {
            //            temp = Mas1[i];
            //            Mas1[i] = Mas1[j];
            //            Mas1[j] = temp;
            //        }
            //    }
            //}
            //for (var i = 0; i < Mas1.Length; i++)
            //{
            //    txtVivod.Text += Mas1[i].ToString() + " ";
            //}




            //txtViod.Text = string.Join("", txtVvod.Text.Split(' ').Select(x => int.Parse(x)).ToArray());


        }


    }
}