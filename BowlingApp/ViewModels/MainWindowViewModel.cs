using BowlingApp.Usecase;
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

        //public MainWindowViewModel()
        //{
        //    // ボタンが押下された時のメソッドを登録
        //    StartButtonClickCommand = new DelegateCommand(OnThrowButtonClick);
        //}

        public DelegateCommand StartButtonClickCommand { get; }

        #region ラベル

        // ラベルの初期値を設定
        private string _scoreA_1 = String.Empty;
        private string _scoreA_2 = String.Empty;
        private string _scoreA_3 = String.Empty;
        private string _scoreA_4 = String.Empty;
        private string _scoreA_5 = String.Empty;
        private string _scoreA_6 = String.Empty;
        private string _scoreA_7 = String.Empty;
        private string _scoreA_8 = String.Empty;
        private string _scoreA_9 = String.Empty;
        private string _scoreA_10_1 = String.Empty;
        private string _scoreA_10_2 = String.Empty;
        private string _scoreA_10_3 = String.Empty;

        private string _scoreB_1 = String.Empty;
        private string _scoreB_2 = String.Empty;
        private string _scoreB_3 = String.Empty;
        private string _scoreB_4 = String.Empty;
        private string _scoreB_5 = String.Empty;
        private string _scoreB_6 = String.Empty;
        private string _scoreB_7 = String.Empty;
        private string _scoreB_8 = String.Empty;
        private string _scoreB_9 = String.Empty;
        private string _scoreB_10_1 = String.Empty;
        private string _scoreB_10_2 = String.Empty;
        private string _scoreB_10_3 = String.Empty;

        // ラベルの登録
        public string scoreA_1
        {
            get { return _scoreA_1; }
            set { SetProperty(ref _scoreA_1, value); }
        }
        public string scoreB_1
        {
            get { return _scoreB_1; }
            set { SetProperty(ref _scoreB_1, value); }
        }
        public string scoreA_2
        {
            get { return _scoreA_2; }
            set { SetProperty(ref _scoreA_2, value); }
        }
        public string scoreB_2
        {
            get { return _scoreB_2; }
            set { SetProperty(ref _scoreB_2, value); }
        }
        public string scoreA_3
        {
            get { return _scoreA_3; }
            set { SetProperty(ref _scoreA_3, value); }
        }
        public string scoreB_3
        {
            get { return _scoreB_3; }
            set { SetProperty(ref _scoreB_3, value); }
        }
        public string scoreA_4
        {
            get { return _scoreA_4; }
            set { SetProperty(ref _scoreA_4, value); }
        }
        public string scoreB_4
        {
            get { return _scoreB_4; }
            set { SetProperty(ref _scoreB_4, value); }
        }
        public string scoreA_5
        {
            get { return _scoreA_5; }
            set { SetProperty(ref _scoreA_5, value); }
        }
        public string scoreB_5
        {
            get { return _scoreB_5; }
            set { SetProperty(ref _scoreB_5, value); }
        }
        public string scoreA_6
        {
            get { return _scoreA_6; }
            set { SetProperty(ref _scoreA_6, value); }
        }
        public string scoreB_6
        {
            get { return _scoreB_6; }
            set { SetProperty(ref _scoreB_6, value); }
        }
        public string scoreA_7
        {
            get { return _scoreA_7; }
            set { SetProperty(ref _scoreA_7, value); }
        }
        public string scoreB_7
        {
            get { return _scoreB_7; }
            set { SetProperty(ref _scoreB_7, value); }
        }
        public string scoreA_8
        {
            get { return _scoreA_8; }
            set { SetProperty(ref _scoreA_8, value); }
        }
        public string scoreB_8
        {
            get { return _scoreB_8; }
            set { SetProperty(ref _scoreB_8, value); }
        }
        public string scoreA_9
        {
            get { return _scoreA_9; }
            set { SetProperty(ref _scoreA_9, value); }
        }
        public string scoreB_9
        {
            get { return _scoreB_9; }
            set { SetProperty(ref _scoreB_9, value); }
        }
        public string scoreA_10_1
        {
            get { return _scoreA_10_1; }
            set { SetProperty(ref _scoreA_10_1, value); }
        }
        public string scoreB_10_1
        {
            get { return _scoreB_10_1; }
            set { SetProperty(ref _scoreB_10_1, value); }
        }
        public string scoreA_10_2
        {
            get { return _scoreA_10_2; }
            set { SetProperty(ref _scoreA_10_2, value); }
        }
        public string scoreB_10_2
        {
            get { return _scoreB_10_2; }
            set { SetProperty(ref _scoreB_10_2, value); }
        }
        public string scoreA_10_3
        {
            get { return _scoreA_10_3; }
            set { SetProperty(ref _scoreA_10_3, value); }
        }
        public string scoreB_10_3
        {
            get { return _scoreB_10_3; }
            set { SetProperty(ref _scoreB_10_3, value); }
        }

        #endregion


        #region メソッド

        /// <summary>投げるボタン実行時の処理</summary>
        //public void OnThrowButtonClick()
        //{
        //    BowlingUsecase bowlingUsecase = new();

        //    //MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
        //    //var properties = GetType().GetProperties();
        //    //var a = properties[2].GetIndexParameters;
        //    //var i = 2;
        //    // var name = properties[i].Name;
        //    // var properties = mainWindowViewModel.GetType().GetProperty($"{name}").GetValue(mainWindowViewModel);

        //    // PropertyInfo propertyInfo = mainWindowViewModel.GetType().GetProperty($"{name}");
        //    //PropertyInfo propertyInfo = mainWindowViewModel.GetType().GetProperty("scoreA_1");
        //    //propertyInfo?.SetValue(mainWindowViewModel, bowlingUsecase.GetScore());

        //    // var a = properties[i].GetProperty(properties[i].Name).GetValue();
            
        //    //while (a.Equals(PropertyAttributes.None))
        //    //{
        //    //    properties[i].SetValue(mainWindowViewModel, bowlingUsecase.GetScore());
        //    //    i++;
        //    //}

        //    if (scoreA_1 == String.Empty) { scoreA_1 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_1 == String.Empty) { scoreB_1 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_2 == String.Empty) { scoreA_2 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_2 == String.Empty) { scoreB_2 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_3 == String.Empty) { scoreA_3 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_3 == String.Empty) { scoreB_3 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_4 == String.Empty) { scoreA_4 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_4 == String.Empty) { scoreB_4 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_5 == String.Empty) { scoreA_5 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_5 == String.Empty) { scoreB_5 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_6 == String.Empty) { scoreA_6 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_6 == String.Empty) { scoreB_6 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_7 == String.Empty) { scoreA_7 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_7 == String.Empty) { scoreB_7 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_8 == String.Empty) { scoreA_8 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_8 == String.Empty) { scoreB_8 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_9 == String.Empty) { scoreA_9 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_9 == String.Empty) { scoreB_9 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_10_1 == String.Empty) { scoreA_10_1 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_10_1 == String.Empty) { scoreB_10_1 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_10_2 == String.Empty) { scoreA_10_2 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_10_2 == String.Empty) { scoreB_10_2 = bowlingUsecase.GetScore(); }
        //    else if (scoreA_10_3 == String.Empty) { scoreA_10_3 = bowlingUsecase.GetScore(); }
        //    else if (scoreB_10_3 == String.Empty) { scoreB_10_3 = bowlingUsecase.GetScore(); }
        //}
        
        #endregion
    }
}
