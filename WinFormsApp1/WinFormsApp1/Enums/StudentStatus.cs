using System;

namespace WinFormsApp1.Enums
{
    [Flags]
    public enum StudentStatus
    {
        None = 0,
        Married = 1,      // Женат/Замужем
        InDormitory = 2   // Живет в общежитии
    }
}