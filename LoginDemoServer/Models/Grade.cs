using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LoginDemoServer.Models;

public partial class Grade
{
    [Key]
    public int Id { get; set; }

    public int DateOfExam { get; set; }

    [StringLength(100)]
    public string NameOfSubject { get; set; } = null!;

    [Column("Grade")]
    public int Grade1 { get; set; }

    [Column("UserID")]
    [StringLength(100)]
    public string UserId { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Grades")]
    public virtual User User { get; set; } = null!;
}
