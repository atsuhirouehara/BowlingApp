using System;
using System.Collections.Generic;
using BowlingApp.Models;
using BowlingApp.Usecase;
using Prism.Commands;
using Prism.Mvvm;

namespace BowlingApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        // タイトルの設定
        private string _title = "Bowling App";
        public string Title
        {
            get { return this._title; }
            set { this.SetProperty(ref this._title, value); }
        }

        public DelegateCommand ThrowButtonClickCommand { get; }
        public DelegateCommand ScoreButtonClickCommand { get; }

        public MainWindowViewModel()
        {
            // ボタンが押下された時のメソッドを登録
            this.ThrowButtonClickCommand = new delegatecommand(this.OnThrowButtonClick);
            this.ScoreButtonClickCommand = new DelegateCommand(this.OnScoreButtonClick);
        }

        #region プロパティ

        private BowlingUsecase bowlingUsecase = new BowlingUsecase(new Bowling());

        private List<string> ScoreA = new List<string>();
        //private List<string> ScoreB;

        #endregion

        #region ラベル

        // ラベルの初期値を設定
        private string _throw1_1 = String.Empty;
        private string _throw1_2 = String.Empty;
        private string _throw2_1 = String.Empty;
        private string _throw2_2 = String.Empty;
        private string _throw3_1 = String.Empty;
        private string _throw3_2 = String.Empty;
        private string _throw4_1 = String.Empty;
        private string _throw4_2 = String.Empty;
        private string _throw5_1 = String.Empty;
        private string _throw5_2 = String.Empty;
        private string _throw6_1 = String.Empty;
        private string _throw6_2 = String.Empty;
        private string _throw7_1 = String.Empty;
        private string _scoreA = String.Empty;

        // ラベルの登録
        public string throw1_1
        {
            get { return this._throw1_1; }
            set { this.SetProperty(ref this._throw1_1, value); }
        }
        public string throw1_2
        {
            get { return this._throw1_2; }
            set { this.SetProperty(ref this._throw1_2, value); }
        }
        public string throw2_1
        {
            get { return this._throw2_1; }
            set { this.SetProperty(ref this._throw2_1, value); }
        }
        public string throw2_2
        {
            get { return this._throw2_2; }
            set { this.SetProperty(ref this._throw2_2, value); }
        }
        public string throw3_1
        {
            get { return this._throw3_1; }
            set { this.SetProperty(ref this._throw3_1, value); }
        }
        public string throw3_2
        {
            get { return this._throw3_2; }
            set { this.SetProperty(ref this._throw3_2, value); }
        }
        public string throw4_1
        {
            get { return this._throw4_1; }
            set { this.SetProperty(ref this._throw4_1, value); }
        }
        public string throw4_2
        {
            get { return this._throw4_2; }
            set { this.SetProperty(ref this._throw4_2, value); }
        }
        public string throw5_1
        {
            get { return this._throw5_1; }
            set { this.SetProperty(ref this._throw5_1, value); }
        }
        public string throw5_2
        {
            get { return this._throw5_2; }
            set { this.SetProperty(ref this._throw5_2, value); }
        }
        public string throw6_1
        {
            get { return this._throw6_1; }
            set { this.SetProperty(ref this._throw6_1, value); }
        }
        public string throw6_2
        {
            get { return this._throw6_2; }
            set { this.SetProperty(ref this._throw6_2, value); }
        }
        public string throw7_1
        {
            get { return this._throw7_1; }
            set { this.SetProperty(ref this._throw7_1, value); }
        }
        public string scoreA
        {
            get { return this._scoreA; }
            set { this.SetProperty(ref this._scoreA, value); }
        }
        #endregion


        #region メソッド

        /// <summary>投げるボタン実行時の処理</summary>
        private void OnThrowButtonClick()
        {

            //MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            //var properties = GetType().GetProperties();
            //var a = properties[2].GetIndexParameters;
            //var i = 2;
            // var name = properties[i].Name;
            // var properties = mainWindowViewModel.GetType().GetProperty($"{name}").GetValue(mainWindowViewModel);

            // PropertyInfo propertyInfo = mainWindowViewModel.GetType().GetProperty($"{name}");
            //PropertyInfo propertyInfo = mainWindowViewModel.GetType().GetProperty("scoreA_1");
            //propertyInfo?.SetValue(mainWindowViewModel, bowlingUsecase.GetScore());

            // var a = properties[i].GetProperty(properties[i].Name).GetValue();

            //while (a.Equals(PropertyAttributes.None))
            //{
            //    properties[i].SetValue(mainWindowViewModel, bowlingUsecase.GetScore());
            //    i++;
            //}

            if (this.throw1_1 == String.Empty) { this.throw1_1 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw1_1); }
            else if (this.throw1_2 == String.Empty) { this.throw1_2 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw1_2); }
            else if (this.throw2_1 == String.Empty) { this.throw2_1 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw2_1); }
            else if (this.throw2_2 == String.Empty) { this.throw2_2 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw2_2); }
            else if (this.throw3_1 == String.Empty) { this.throw3_1 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw3_1); }
            else if (this.throw3_2 == String.Empty) { this.throw3_2 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw3_2); }
            else if (this.throw4_1 == String.Empty) { this.throw4_1 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw4_1); }
            else if (this.throw4_2 == String.Empty) { this.throw4_2 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw4_2); }
            else if (this.throw5_1 == String.Empty) { this.throw5_1 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw5_1); }
            else if (this.throw5_2 == String.Empty) { this.throw5_2 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw5_2); }
            else if (this.throw6_1 == String.Empty) { this.throw6_1 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw6_1); }
            else if (this.throw6_2 == String.Empty) { this.throw6_2 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw6_2); }
            else if (this.throw7_1 == String.Empty) { this.throw7_1 = this.bowlingUsecase.GetThrowResult(); this.ScoreA.Add(this.throw7_1); }
        }

        private void OnScoreButtonClick()
        {
            // 投げ終わっていない場合にボタンが押されたときの例外処理も必要
            this.scoreA = "OK";
            //this.scoreA = this.bowlingUsecase.GetScore();
            //this.scoreB = this.bowlingUsecase.GetScore();
        }

        #endregion
    }
}
