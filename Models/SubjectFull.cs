namespace ApiSysSchoolar.Models;

public class SubjectFull
{
    public int idSubjectFull { get; set; }
    public DateOnly yearSf { get; set; }
    public int idScheduleSf { get; set; }
    public int idSubjectSf { get; set; }
    public int idTeacherSf { get; set; }

    public virtual Schedules Schedules { get; set; } = null!;
    public virtual Subjects Subjects { get; set; } = null!;
    public virtual Teachers Teachers { get; set; } = null;
}

