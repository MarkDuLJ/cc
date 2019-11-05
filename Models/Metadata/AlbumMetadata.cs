using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    [ModelMetadataType(typeof(AlbumMetadata))]
    public partial class Album { }
    public class AlbumMetadata
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        [DisplayName("Artist")]
        public int ArtistId { get; set; }

        [DisplayName("Title")]
        [Required]
        [StringLength(50)]
        [DisplayFormat(ConvertEmptyStringToNull =true,NullDisplayText ="Null")]
        public string Title { get; set; }

        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:c")]
        public double Price { get; set; }

        [DisplayName("Album Art Url")]
        //[HiddenInput(DisplayValue=true)]
        [ReadOnly(true)]
        [DataType(DataType.Url)]
        public string AlbumArtUrl { get; set; }
    }
}
