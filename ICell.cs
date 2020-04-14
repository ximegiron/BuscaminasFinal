//ximena
namespace Buscaminas //Cambiar el nombre del namespace
{
    interface ICell 
    {
        int GetValue();
        bool IsHidden();
        Celda.Status GetStatus();
        void LeftClick();
        void RightClick();
        //void SetValue(int val);
    }
}
