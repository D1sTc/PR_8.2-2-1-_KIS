﻿using System;
using System.Collections.Generic;
using System.Data;
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

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Autorization_Click(object sender, RoutedEventArgs e)
        {
            //if (textBox_login.Text.Length > 0) // проверяем введён ли логин     
            //{
            //    if (password.Password.Length > 0) // проверяем введён ли пароль         
            //    {             // ищем в базе данных пользователя с такими данными         
            //        DataTable dt_user = mainWindow.Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + textBox_login.Text + "' AND [password] = '" + password.Password + "'");
            //        if (dt_user.Rows.Count > 0) // если такая запись существует       
            //        {
            //            MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался         
            //        }
            //        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
            //    }
            //    else MessageBox.Show("Введите пароль"); // выводим ошибку    
            //}
            //else MessageBox.Show("Введите логин"); // выводим ошибку 
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
