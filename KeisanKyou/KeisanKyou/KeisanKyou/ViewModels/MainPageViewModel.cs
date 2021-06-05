using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;
using System.ComponentModel;
using KeisanKyou.Common;
using KeisanKyou.Views;

namespace KeisanKyou.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        //ゲームスタートボタンクリックコマンド
        public ICommand StartGameButtonClicked { get; set; }

        public MainPageViewModel()
        {
            StartGameButtonClicked = new RelayCommand(GameStart);
        }

        private void GameStart()
        {
            Console.WriteLine("ゲームスタート！（ここでGameMain.xamlに遷移）");
        }

        // プロパティ値の変更を通知 関連
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
