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
using WEBCrawler.ModelView;

namespace WEBCrawler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CrawlerWindow : Window
    {
        private CrawlerHandler handler = new CrawlerHandler();

        public CrawlerWindow()
        {
            InitializeComponent();
            this.DataContext = handler;
        }
    }
    
}
