using System;
using System.Collections.Generic;

namespace jobseeker_jobs_api.Entities

{
	public class InsertJob
	{
		public long? JobId { get; set; }
		public string JobPositionId { get; set; }
		public long? UserId { get; set; }
		public long? CustomerId { get; set; }
		public int? JobCategoryId { get; set; }
		public string JobTitle { get; set; }
		public int? MinExperienceId { get; set; }
		public int? MaxExperienceId { get; set; }
		public bool? CompleteDescription { get; set; }
		public string JobDescription { get; set; }
		public List<PjSkill> XmlSkills { get; set; }
		public List<PjRole> XmlRoleId { get; set; }
		public int? NumberOfVacancies { get; set; }
		public string PreferredLocationId { get; set; }
		public List<PjEducationDetails> XmlQualifications { get; set; }
		public List<PjDomain> XmlDomains { get; set; }
		public List<PjDisc> XmlPersonType { get; set; }
		public int? EmploymentTypeId { get; set; }
		public string ContractDuration { get; set; }
		public bool? ContractExtended { get; set; }
		public int? WorkAuthorizationId { get; set; }
		public string AfterWhatDuration { get; set; }
		public int? SalaryTypeId { get; set; }
		public string MinimumSalary { get; set; }
		public string MaximumSalary { get; set; }
		public bool? HideSalary { get; set; }
		public bool BonusOffered { get; set; }
		public int? HiringProcessId { get; set; }
		public int? HiringManagerId { get; set; }
		public List<PjTechnicalTeam> XmlTechnicalTeam { get; set; }
		public List<PjDepartment> XmlDepartment { get; set; }
		public bool? IsPrivate { get; set; }
		public List<PjJobAccessTo> XmlAccessToUsers { get; set; }
		public DateTime? ExpiryDate { get; set; }
		public string ClientName { get; set; }
		public int? ClientId { get; set; }
		public bool? SaveAsTemplate { get; set; }
		public int? StepNumber { get; set; }
		public bool? IsDrafted { get; set; }
		public bool? Draft { get; set; }
		public bool? RemoteWorkId { get; set; }
		public string TemplateSaveTitle { get; set; }
		public string Email { get; set; }
		public Nullable<int> JobPriority { get; set; }

		public Nullable<int> JobDue { get; set; }

		public List<JobSearchMatchingCrieteria> MatchingCrieterias { get; set; }
		public InsertJob()
		{
			MatchingCrieterias = new List<JobSearchMatchingCrieteria>();
		}
	}

	public class PjSkill
	{
		public string SkillName { get; set; }

		public bool? SkillType { get; set; }

		public int MinimumExp { get; set; }
		public int MaximumExp { get; set; }
	}

	public class PjRole
	{
		public long RoleId { get; set; }
	}

	public class PjDisc
	{
		public int? DiscTestId { get; set; }

	}
	public class PjDomain
	{
		public bool? ExperienceRequired { get; set; }

		public long DomainId { get; set; }
		public int MinimumExperience { get; set; }
		public int MaximumExperience { get; set; }
		public string Description { get; set; }
	}
	public class PjEducationDetails
	{
		public int QualificationId { get; set; }
		public bool? IsActive { get; set; }

	}
	public class PjTechnicalTeam
	{
		public long UserId { get; set; }
	}
	public class PjDepartment
	{
		public int? DepartmentId { get; set; }
	}
	public class PjJobAccessTo
	{
		public long UserId { get; set; }
		public long CustomerId { get; set; }
	}

	public class JobSearchMatchingCrieteria
	{
		public long ParameerId { get; set; }
		public long Percentage { get; set; }
	}
}
