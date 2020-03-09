using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorWOL.Shared
{
    public class Device
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "デバイス名を入力してください。")]
        [StringLength(20, ErrorMessage = "デバイス名は 20 文字までです。")]
        public string Name { get; set; }

        [Required(ErrorMessage = "MAC アドレスを入力してください。")]
        [RegularExpression(@"(?i)^[\da-f]{2}((:|-)[\da-f]{2}){5}$", ErrorMessage = "MAC アドレスの書式が正しくありません。")]
        public string MACAddress { get; set; }
    }
}