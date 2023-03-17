﻿using System;
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

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePW7.xaml
    /// </summary>
    public partial class PagePW7 : Page
    {
        int N;

        int[] array;
        public PagePW7()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Создание массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnCreateArray_Click(object sender, RoutedEventArgs e)
        {
            N = int.Parse(TxtN.Text);

            array = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(-1000, 1000);
                LstArray1.Items.Add($"№{i} {array[i]}");
            }
        }
        private void BtnSolveArray_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] < 0)
                {
                    break;
                }
                else
                {
                    sum=sum + array[i];
                }
              
            } 
            LstArray2.Items.Add($"Сумма до 1го отрицательного {sum}");
        }
    }
}