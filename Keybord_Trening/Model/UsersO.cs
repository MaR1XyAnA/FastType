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
    
    public partial class UsersO
    {
        public UsersO()
        {
            this.UserRating = new HashSet<UserRating>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<UserRating> UserRating { get; set; }
    }
}
