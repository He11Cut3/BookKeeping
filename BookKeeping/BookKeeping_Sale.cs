//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookKeeping
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookKeeping_Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookKeeping_Sale()
        {
            this.BookKeeping_Main = new HashSet<BookKeeping_Main>();
        }
    
        public int BookKeeping_Sale_Id { get; set; }
        public string BookKeeping_Sale_Article { get; set; }
        public string BookKeeping_Sale_Date { get; set; }
        public string BookKeeping_Sale_Stock { get; set; }
        public string BookKeeping_Sale_Total { get; set; }

        public string S_Article
        {
            get
            {
                return "Артикуль: " + this.BookKeeping_Sale_Article;
            }
        }
        public string S_Date
        {
            get
            {
                return "Дата продажи: " + this.BookKeeping_Sale_Date;
            }
        }
        public string S_Stock
        {
            get
            {
                return "Место продажи (Наим.организации): " + this.BookKeeping_Sale_Stock;
            }
        }
        public string S_Total
        {
            get
            {
                return "Выручка: " + this.BookKeeping_Sale_Total;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookKeeping_Main> BookKeeping_Main { get; set; }
    }
}
