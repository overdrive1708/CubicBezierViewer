using CommunityToolkit.Mvvm.ComponentModel;

namespace CubicBezierViewer.ViewModels
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        //--------------------------------------------------
        // バインディングデータ
        //--------------------------------------------------
        /// <summary>
        /// タイトル
        /// </summary>
        [ObservableProperty]
        private string _title;

        //--------------------------------------------------
        // メソッド
        //--------------------------------------------------
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel()
        {
            // タイトル表示内容の生成
            Title = "CubicBezierViewer";
        }
    }
}
