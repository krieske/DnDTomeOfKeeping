//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DnDTomeOfKeeping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Character()
        {
            this.Campaigns = new HashSet<Campaign>();
            this.Proficiencies1 = new HashSet<Proficiency>();
            this.Spells = new HashSet<Spell>();
        }
    
        public int CharID { get; set; }
        public string CharName { get; set; }
        public int Class { get; set; }
        public int HitPoints { get; set; }
        public string Alignment { get; set; }
        public int CharLevel { get; set; }
        public string Feats { get; set; }
        public string Equipment { get; set; }
        public string Features { get; set; }
        public Nullable<int> Campaign { get; set; }
        public string UserID { get; set; }
        public string Race { get; set; }
        public string SpellsKnown { get; set; }
        public string Proficiencies { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Campaign> Campaigns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proficiency> Proficiencies1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spell> Spells { get; set; }
    }
}
