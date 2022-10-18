﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Пять
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

        Liquid liquid1;
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                liquid1 = new Liquid(Convert.ToString(name.Text), Convert.ToDouble(dens.Text), Convert.ToDouble(vol.Text));
                liquid1_info.Text = liquid1.LiquidInfo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Dif_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (liquid1 != null && liquid2 != null)
                {
                    if (rb_dens.IsChecked == true) result.Text = Convert.ToString(liquid1.DensityDifference(liquid2));
                    else result.Text = Convert.ToString(liquid1.VolumeDifference(liquid2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Liquid liquid2;
        private void btn_Add2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                liquid2 = new Liquid(Convert.ToString(l2_name.Text), Convert.ToDouble(l2_dens.Text), Convert.ToDouble(l2_vol.Text));
                liquid2_info.Text = liquid2.LiquidInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Edit2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                liquid2.SetParams(Convert.ToString(l2_name.Text), Convert.ToDouble(l2_dens.Text), Convert.ToDouble(l2_vol.Text));
                liquid2_info.Text = liquid2.LiquidInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                liquid1.SetParams(Convert.ToString(name.Text), Convert.ToDouble(dens.Text), Convert.ToDouble(vol.Text));
                liquid1_info.Text = liquid1.LiquidInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
