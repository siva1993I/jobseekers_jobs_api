using System;
using System.Collections.Generic;

namespace jobseeker_jobs_api.Entities
{
    public class JobInfo
    {
        public long JobId { get; set; }
        public string? JobPositionId { get; set; }
        public long UserId { get; set; }
        public long CustomerId { get; set; }
        public string? JobTitle { get; set; }
        
        public Nullable<int> NumberOfVacancies { get; set; }
     
        public Nullable<int> ClientId { get; set; }
      
        public Nullable<bool> IsActive { get; set; }
       
        public Nullable<bool> IsDrafted { get; set; }
        public System.DateTime PostedDate { get; set; }
        public long PostedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
       
        public Nullable<System.DateTime> ExpiryDate { get; set; }
      
        public string? JobPriority { get; set; }

    }
	public class ImageInfo
	{
		public byte[] ImageByte { get; set; }
	}

	public class SearchProfileInput
	{
		public SearchProfileInput()
		{
			QualificationId = 0;
			PageNumber = 1;
			NumberOfRows = 12;
		}
		public string SearchString { get; set; }
		public string Experience { get; set; }
		public string Location { get; set; }
		public int QualificationId { get; set; }
		public int PageNumber { get; set; }
		public int NumberOfRows { get; set; }
		public long? CustomerId { get; set; }
		public long? JobId { get; set; }
	}

	public class MatchedProfileCount
	{
		public MatchedProfileCount()
		{
			Profile = new List<MatchedProfile>();

		}

		public int TotalProfileCount { get; set; }
		public double TotalPages { get; set; }
		public List<MatchedProfile> Profile { get; set; }


	}

	public class MatchedProfile
	{
		public MatchedProfile()
		{
			profileMap = new ProfileMap();
			countval = new CountsForProfile();
		}

		public long? UserId { get; set; }
		public long? CCPID { get; set; }
		public int? MatchingPercentage { get; set; }
		// public string ProfilePic { get; set; }
		public string ProfilePic { get; set; }
		public string ResumeUrl { get; set; }
		public Nullable<long> ResumeId { get; set; }
		public long? ProfileId { get; set; }
		public string ProfileTitle { get; set; }
		public string CompanyName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public bool? IsConfirmed { get; set; }
		public string JobStatus { get; set; }
		public string TotalExperience { get; set; }
		public string CurrentLocation { get; set; }
		public int? ResponseStatusId { get; set; }
		public long? JobResponseId { get; set; }
		public string AboutMe { get; set; }
		public DateTime? ModifiedOn { get; set; }
		public bool? IsCertified { get; set; }
		public string PrimarySkills { get; set; }
		public int? TotalProfileCount { get; set; }
		public string DiscResult { get; set; }
		public Nullable<bool> BackGroundCheck { get; set; }
		public DateTime? CreatedOn { get; set; }
		public string DomainName { get; set; }
		public string CertificationName { get; set; }
		public int? MobileCountryCodeId { get; set; }
		public string MobilePhone { get; set; }
		public Nullable<long> VideoSizzleId { get; set; }
		public string VideoSizzle { get; set; }
		public string VideoProfile { get; set; }
		public string VideoFormat { get; set; }
		public string QualificationName { get; set; }
		public string Specialization { get; set; }
		public string InstituteORUniversity { get; set; }
		public string Location { get; set; }

		public decimal TeamFit { get; set; }
		public decimal SkillFit { get; set; }

		public decimal JobFit { get; set; }

		public decimal PersonalFit { get; set; }

		public decimal CultureFit { get; set; }
		public Nullable<int> FromYear { get; set; }
		public Nullable<int> ToYear { get; set; }
		public Nullable<bool> IsSaved { get; set; }
		public bool NoEmail { get; set; }
		public bool? IsUploaded { get; set; }
		public bool? IsInvited { get; set; }
		public ProfileMap profileMap { get; set; }
		public List<string> Pskills { get; set; }

		public int? AchivementCount { get; set; }

		public List<string> InterviewRounds { get; set; }
		public CountsForProfile countval { get; set; }
		public byte[] ProfilePicBytes { get; set; }

		public int? NotesCount { get; set; }
	}

	public class ProfileMap
	{
		public ProfileMap()
		{
			profileVal = new ProfileVal();

		}
		public Nullable<long> CustomerId { get; set; }
		public Nullable<long> ProfileId { get; set; }
		public string Email { get; set; }
		public Nullable<bool> IsPublic { get; set; }
		public ProfileVal profileVal { get; set; }

	}

	public class ProfileVal
	{
		public long? UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string MobilePhone { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public Nullable<int> CityId { get; set; }
		public string CityName { get; set; }
		public Nullable<int> StateId { get; set; }
		public string StateName { get; set; }
		public string ZipCode { get; set; }
		public Nullable<long> VideoProfileId { get; set; }
		public string SkypeId { get; set; }
		public string AboutMe { get; set; }
		public string ProfileTitle { get; set; }
		public string ProfilePic { get; set; }
	}


	public class CountsForProfile
	{
		public Nullable<int> SkillsCount { get; set; }
		public Nullable<int> DomainsCount { get; set; }
		public Nullable<int> CertificationCount { get; set; }
		public Nullable<int> AchievementCount { get; set; }
	}

	public class SaveJob
	{
		public long UserId { get; set; }
		public long JobId { get; set; }

		public long ProfileId { get; set; }
	}

	public class InsertDislikes
	{
		public long? jobId { get; set; }
		public long? userId { get; set; }
	}

	public class Savefilter
	{

		public long? CustomerId { get; set; }
		public long? UserId { get; set; }
		public int? SortBy { get; set; }
		public int? Status { get; set; }
		public int? MinSal { get; set; }
		public int? MaxSal { get; set; }
		public int? MinExp { get; set; }
		public int? MaxExp { get; set; }
		public string JobStatus { get; set; }
		public string locations { get; set; }
		public string skills { get; set; }
		public string clients { get; set; }
		public string titles { get; set; }
		public string departments { get; set; }
		public string domain { get; set; }
		public string Immigration { get; set; }
		public string lastWeek { get; set; }
		public string lastTwoWeek { get; set; }
		public string last30days { get; set; }
		public string last90days { get; set; }
		public string lastyear { get; set; }
		public string today { get; set; }
		public string category { get; set; }
		public string empType { get; set; }
		public string education { get; set; }
		public string users { get; set; }

	}

	public class JobComments
	{
		public long? JobCommentId { get; set; }
		public long? JobId { get; set; }
		public long? UserId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string CommentText { get; set; }
		public bool? isPrivate { get; set; }
		public bool? isDeleted { get; set; }
		public string ProfilePic { get; set; }
		public string ProfileTitle { get; set; }
		public string CommentedDate { get; set; }
		public System.DateTime? ModifiedOn { get; set; }
		public int? CommentsCount { get; set; }
	}

	public class CandidateLikes
	{
		public long? CandidateLikeId { get; set; }
		public long? CustomerUserId { get; set; }
		public long? CandidateUserId { get; set; }
		public long? JobId { get; set; }
		public bool? IsLiked { get; set; }
	}

	public class InsertLikes
	{
		public long? jobId { get; set; }
		public long? userId { get; set; }
		public bool? isLiked { get; set; }
		public bool? isPending { get; set; }
	}

	public class JobPreferences
	{
		public long? UserId { get; set; }
		public long? JobPreferenceId { get; set; }
		public bool? RoleAlerts { get; set; }
		public string PreferredRole { get; set; }
		public bool? SkillAlerts { get; set; }
		public string PreferredSkill { get; set; }
		public bool? LocationAlerts { get; set; }
		public bool? WorkInUs { get; set; }
		public bool? VisaStatus { get; set; }
		public int? CurrentStatusId { get; set; }
		public int? RemoteWorkId { get; set; }
		public long? JobCategoryId { get; set; }
		public string BasicSalary { get; set; }
		public Nullable<int> TravelPercentageId { get; set; }
		public bool? Relocation { get; set; }
		public bool? Travel { get; set; }
		public decimal? TravelPercentage { get; set; }
		public bool? DruckCheck { get; set; }
		public string EmploymentType { get; set; }
		public long? WorkingHoursId { get; set; }
		public Nullable<bool> SalaryRangeId { get; set; }
		public string MinimumSalary { get; set; }
		public string MaximumSalary { get; set; }
		//public List<PreferredLocation> PreferredLocation { get; set; }
		public string DomainName { get; set; }
		public Nullable<bool> ProfileSearchable { get; set; }
		public List<JpCompany> XmlCompany { get; set; }
		public List<JpCategory> XmlCategory { get; set; }
		public List<JpLocation> XmlLocation { get; set; }
		public List<JpRole> XmlRole { get; set; }
		public List<JpSkill> XmlSkill { get; set; }
		public Nullable<int> CompanyListId { get; set; }
		public Nullable<long> CompanySizeId { get; set; }
	}

	public class JpCompany
	{
		public string company { get; set; }
	}

	public class JpCategory
	{
		public long? JobCategoryId { get; set; }
	}
	public class JpLocation
	{
		public long? CityId { get; set; }
		public long? StateId { get; set; }
	}
	public class JpSkill
	{
		public long? Id { get; set; }
	}
	public class JpRole
	{
		public long? JobRoleId { get; set; }
	}

	public class InsertJobAlert
	{
		public Nullable<long> jobAlertId { get; set; }
		public Nullable<long> userId { get; set; }
		public string jobAlertName { get; set; }
		public string jobTitle { get; set; }
		public string jobRole { get; set; }
		public string location { get; set; }
		public Nullable<int> distance { get; set; }
		public Nullable<int> subsciptionTypeId { get; set; }
		public Nullable<bool> alertRequired { get; set; }
		public Nullable<int> scheduleTypeId { get; set; }
		public Nullable<int> experienceLevelId { get; set; }
		public Nullable<int> employmenttypeId { get; set; }
		public Nullable<int> domainId { get; set; }
	}

	public class UpdateInterview
	{
		public long? CustomerId { get; set; }
		public long? UserId { get; set; }
		public long? JobId { get; set; }
		public bool? IsCandidateAccepted { get; set; }
		public bool? IsCPNewDate { get; set; }
		public DateTime? CPDate { get; set; }
		public string CPFromTime { get; set; }
	}

	public class InterviewAcceptance
	{
		public long? userId { get; set; }
		public long? jobId { get; set; }
		public bool? IsCandidateAccepted { get; set; }
		public bool? IsCPNewDate { get; set; }
		public DateTime? CPDate { get; set; }
		public string CPFromTime { get; set; }
		public string CPToTime { get; set; }
		public string CandidateComments { get; set; }
		public DateTime? ModifiedOn { get; set; }
		public long? ModifiedBy { get; set; }
	}

	public class Savesearch
	{
		public long? UserId { get; set; }
		public string SavedSearchTitle { get; set; }
		public string JobTitle { get; set; }
		public string Location { get; set; }
		public string EmploymentTypeId { get; set; }
		public int? distanceId { get; set; }
		public int? postedOn { get; set; }
		public int? domainId { get; set; }
		public int? experienceLevelId { get; set; }
		public string minimumSalary { get; set; }
		public string maximumSalary { get; set; }
		public bool? Flag { get; set; }
	}

	public class InterviewCalendar
	{
		public long? UserId { get; set; }
		public long? CustomerId { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public int? Month { get; set; }
		public int? Year { get; set; }
		public int? SortBy { get; set; }
		public int? PageNumber { get; set; }
		public int? NumberOfRows { get; set; }
	}

	public partial class SaveConversation
	{
		public long? conversationId { get; set; }
		public long? jobId { get; set; }
		public long? senderId { get; set; }
		public long? receiverId { get; set; }
		public string replyText { get; set; }
		public bool? isRead { get; set; }
		public bool? isDeleted { get; set; }
	}

	public class InsertRoles
	{
		public long? UserId { get; set; }
		public long? JobId { get; set; }
		public List<JobRole> XmlRoles { get; set; }

	}

	public class JobRole
	{
		public string RolesandResponsibilities { get; set; }
	}

	public partial class CandidateSkippedDomain
	{
		public long Id { get; set; }
		public Nullable<long> ProfileId { get; set; }
		public Nullable<long> JobId { get; set; }
		public Nullable<long> DomainId { get; set; }
		public Nullable<System.DateTime> CreatedOn { get; set; }
		public Nullable<long> CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedOn { get; set; }
		public Nullable<long> ModifiedBy { get; set; }
		public Nullable<long> IsUpdated { get; set; }

		public virtual DomainName DomainName { get; set; }
	}

	public partial class DomainName
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public DomainName()
		{
			this.CandidateSkippedDomains = new HashSet<CandidateSkippedDomain>();
			this.JobAlerts = new HashSet<JobAlert>();
		}

		public long DomainId { get; set; }
		public string DomainName1 { get; set; }
		public string Description { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<CandidateSkippedDomain> CandidateSkippedDomains { get; set; }
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<JobAlert> JobAlerts { get; set; }
	}

	public partial class JobAlert
	{
		public long JobAlertId { get; set; }
		public Nullable<long> UserId { get; set; }
		public string JobAlertName { get; set; }
		public string JobTitle { get; set; }
		public string JobRole { get; set; }
		public string Location { get; set; }
		public Nullable<int> Distance { get; set; }
		public Nullable<int> SubsciptionTypeId { get; set; }
		public Nullable<int> ExperienceLevelId { get; set; }
		public Nullable<int> EmploymentTypeId { get; set; }
		public Nullable<long> DomainId { get; set; }
		public Nullable<bool> AlertRequired { get; set; }
		public Nullable<int> ScheduleTypeId { get; set; }
		public Nullable<System.DateTime> CreatedOn { get; set; }
		public Nullable<long> CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedOn { get; set; }
		public Nullable<long> ModifiedBy { get; set; }

		public virtual DomainName DomainName { get; set; }
		//public virtual EmploymentType EmploymentType { get; set; }
		//public virtual ExperienceLevel ExperienceLevel { get; set; }
		//public virtual ScheduleType ScheduleType { get; set; }
		//public virtual SubsciptionType SubsciptionType { get; set; }
		//public virtual User User { get; set; }
	}


}
