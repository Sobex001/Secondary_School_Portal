﻿public class TeacherReadDTO
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public List<string> Subjects { get; set; } = new();
}
