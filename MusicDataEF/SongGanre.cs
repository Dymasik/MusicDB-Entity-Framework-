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
    
    public partial class SongGanre
    {
        public int SG_id { get; set; }
        public int SG_songId { get; set; }
        public int SG_ganreId { get; set; }
    
        public virtual Ganres Ganres { get; set; }
        public virtual Songs Songs { get; set; }
    }
}