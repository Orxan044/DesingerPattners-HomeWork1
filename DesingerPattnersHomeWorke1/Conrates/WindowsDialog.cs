using DesingerPattnersHomeWorke1.Abstract;
using DesingerPattnersHomeWorke1.Interface;

namespace DesingerPattnersHomeWorke1.Content;

public class WindowsDialog : Dialog
{
    public override IButton CreatButton() => new WindowsButton();
}
