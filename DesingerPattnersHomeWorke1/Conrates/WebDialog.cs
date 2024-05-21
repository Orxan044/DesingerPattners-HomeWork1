using DesingerPattnersHomeWorke1.Abstract;
using DesingerPattnersHomeWorke1.Interface;

namespace DesingerPattnersHomeWorke1.Content;

public class WebDialog : Dialog
{
    public override IButton CreatButton() => new HTMLButton();
}
