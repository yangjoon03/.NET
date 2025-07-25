namespace Maui_study;

public partial class EventExample : ContentPage
{
    int count = 0;
    public EventExample()
	{
		InitializeComponent();
	}
    private void OnButtonClickedLabel(object sender, EventArgs e)
    {
        resultLabel.Text = (count++)+ "번 클릭되었습니다!";//텍스트 변경
    }
    private void OnButtonClickedDisplayAlert(object sender, EventArgs e)
    {
        DisplayAlert("알림", "버튼이 클릭되었습니다!", "확인");//창알림
    }
}
