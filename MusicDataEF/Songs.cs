//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Songs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Songs()
        {
            this.SongGanre = new HashSet<SongGanre>();
        }
    
        public int S_id { get; set; }
        public string S_name { get; set; }
        public Nullable<int> S_length { get; set; }
        public int S_albId { get; set; }
    
        public virtual Albums Albums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SongGanre> SongGanre { get; set; }
    }
}
