using DesingerPattnersHomeWorke1.Interface;

namespace DesingerPattnersHomeWorke1.Abstract;

public abstract class Dialog
{
    public abstract IButton CreatButton();

    public void Render()
    {
        IButton OkButton = CreatButton();
        OkButton.OnClick();
    }
}
