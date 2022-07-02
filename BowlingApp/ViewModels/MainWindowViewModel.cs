using Prism.Commands;
using Prism.Mvvm;
using System;

namespace BowlingApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        // タイトルの設定
        private string _title = "Bowling App";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            // ボタンが押下された時のメソッドを登録
            StartButtonClickCommand = new DelegateCommand(OnStartButtonClick);
        }

        public DelegateCommand StartButtonClickCommand { get; }

        // ラベルの登録
        private string _scoreA_1 = String.Empty;
        public string scoreA_1
        {
            get { return _scoreA_1; }
            set { SetProperty(ref _scoreA_1, value); }
        }

        /// <summary>投げるボタン実行時の処理</summary>
        public void OnStartButtonClick()
        {
            scoreA_1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
