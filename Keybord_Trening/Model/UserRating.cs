//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Keybord_Trening.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRating
    {
        public int Id { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> TestID { get; set; }
        public Nullable<int> SpeedID { get; set; }
        public string Accuracy { get; set; }
    
        public virtual UsersO UsersO { get; set; }
    }
}
