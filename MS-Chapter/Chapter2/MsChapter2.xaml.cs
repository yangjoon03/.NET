using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace Maui_study;

public partial class MsChapter2 : ContentPage
{
    Button loginButton;
    VerticalStackLayout layout;
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public const double MyFontSize = 23;


    public MsChapter2()
    {
        InitializeComponent();
        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
    }
    void LoginButton_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Clicked !");
        DisplayAlert("알림", "버튼이 클릭되었습니다!", "확인");//창알림
    }

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        //저장 로직
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        //삭제 로직
    }
}

//태그 확장
public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return MsChapter2.MyFontSize;
    }
}

public class FontSizeExtension : IMarkupExtension
{
    public string Key { get; set; }

    private static readonly Dictionary<string, double> FontSizes = new()
        {
            { "Title", 36 },
            { "Body", 20 },
            { "Note", 14 },
            { "Huge", 60 }
        };

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        if (!string.IsNullOrEmpty(Key) && FontSizes.TryGetValue(Key, out double size))
            return size;

        // 기본값 지정 (없으면 16)
        return 16;
    }
}
