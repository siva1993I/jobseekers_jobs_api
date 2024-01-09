
using jobseeker_jobs_api.Entities;

namespace jobseeker_jobs_api.Contracts
{
    public interface IJobRepository
    {
		public Task<IEnumerable<dynamic>> GetProcessingJob(long userId);

		public Task<IEnumerable<dynamic>> GetInterviewScheduledJobByProfileId(long profileId = 0, int pageNumber = 1, int pageSize = 10);

		public Task<IEnumerable<dynamic>> RecentSearchInfo(long userId);

		public Task<IEnumerable<dynamic>> GetProfileCount(long jobId, long customerId);

		public Task<IEnumerable<dynamic>> GetCompanyName(string comapnyName);

		public Task<IEnumerable<dynamic>> GetCompanyHeaderInfo(long customerId);

		public Task<IEnumerable<dynamic>> GetJobTitle(string jobtitle);

		public Task<IEnumerable<dynamic>> GetJobs(long userId = 0, long customerId = 0, long jobId = 0, int sortBy = 0, int pageNumber = 1, int pageSize = 10);

		public Task<IEnumerable<dynamic>> GetCustomerSummary(long? customerId, long? userId);

		public Task<IEnumerable<dynamic>> GetJobSavedFilter(long? customerId, long? userId);

		public Task<IEnumerable<dynamic>> GetCustomerJobs(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? pageNumber, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetCustomerJobsUpdate(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? newSortBy, int? pageNumber, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetCustomerFilteredJobs(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? pageNumber, int? minSal, int? maxSal, int? minExp, int? maxExp, string jobStatus, string locations, string skills, string clients, string departments, string titles, string domain, string immigration, string lastWeek, string lastTwoWeek, string last30days, string last90days, string lastyear, string today, string category, string empType, string education, string users, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetJobBasicInfo(long? customerId, long? jobId);

		public Task<IEnumerable<dynamic>> GetOtherJob(long? customerId, long? userId, long? jobId, int? sortBy, int? pageNumber, int? numberOfRows);

		public Task<IEnumerable<dynamic>> GetJobsTemplate(long customerId);

		public Task<IEnumerable<dynamic>> GetApplicantsActivity(long userId, long jobId);

		public Task<IEnumerable<dynamic>> GetInterviewJobs(long userId = 0, int pageNumber = 1, int pageSize = 10);

		public Task<IEnumerable<dynamic>> DashboardSuggestedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int pageNumber = 1, int pageSize = 10);

		public Task<IEnumerable<dynamic>> GetShortlistedJobs(long userId = 0, int pageNumber = 1, int pageSize = 10);

		public Task<IEnumerable<dynamic>> GetInterviewSortBy(long? customerId, int? sortBy, int? listSort, string searchString, int? pageNumber, int? numberOfRows);

		public Task<IEnumerable<dynamic>> SuggestedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetReferrals(long userId, int quarterListId);

		public Task<IEnumerable<dynamic>> DashboardReferredJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int pageNumber = 1, int pageSize = 10);

		public Task<IEnumerable<dynamic>> RefferedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetJobActivity(long userId, long jobId);

		public Task<IEnumerable<dynamic>> RefferedJobsToMe(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> AppliedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, string monthly = null, string quarterly = null, int yearly = 0, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetJobAssignedList(long jobId);

		public Task<IEnumerable<dynamic>> GetJobDetailCustomer(long customerId, long jobId);

		public Task<IEnumerable<dynamic>> GetJobDetailCandidate(long jobId, long userId = 0);

		public Task<IEnumerable<dynamic>> GetJobDetailEmail(long jobId, long userId = 0);

		public Task<IEnumerable<ImageInfo>> GetImage(string imageLocation);

		public Task<IEnumerable<dynamic>> JobRefferedBy(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, string quarterly = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetJobRole(int functionalAreaId);

		public Task<IEnumerable<dynamic>> GetApplicantStatistics(long customerId, long userId, int filter);

		public Task<IEnumerable<dynamic>> GetJobStatistics(long? customerId, long jobId);

		public Task<IEnumerable<dynamic>> GetApplicants(long customerId, long userId, int page, int numberofRows);

		public Task<IEnumerable<dynamic>> GetNotInterestedJobs(long userId, Nullable<int> statusId, int sortBy, int pageNumber, int numberOfRows);

		public Task<IEnumerable<dynamic>> GetPendingJobs(long userId, Nullable<int> statusId, int sortBy, int pageNumber, int numberOfRows);

		public Task<IEnumerable<dynamic>> GetCustomerPreferredLocation(long customerId, bool? isPostajob);

		public Task<IEnumerable<dynamic>> GetJobId(long referralId);

		public Task<IEnumerable<dynamic>> GetNewProfiles(long customerId, long userId, long jobId, int statusId, int sortBy, string searchString, int? experience, string location, string domainName, int? uploaded, int? suggested, int? wishlist, int? invited, int? arytic, int pageNumber, int noOfRows, int FStatus);

		public Task<IEnumerable<dynamic>> GetUserInfoByProfileMapping(long? profileId);

		public Task<IEnumerable<dynamic>> GetMatchingValueFromProfile(long? ProfileId, long? JobId);

		public Task<IEnumerable<dynamic>> GetSavedJobs(long userId = 0, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10);

		public Task<IEnumerable<dynamic>> GetJobPreference(long userId);

		public Task<IEnumerable<dynamic>> GetAutoSearch(string searchText, long? customerId);

		public Task<IEnumerable<dynamic>> GetCandidateRating(long userId, long jobId);

		public Task<IEnumerable<dynamic>> JobMatchingPercentage(long userId, long jobId);

		public Task<IEnumerable<dynamic>> GetPreferredLocation(long userId);

		public Task<IEnumerable<dynamic>> GetPreferredSkill(long userId);

		public Task<IEnumerable<dynamic>> GetPreferredEmploymentType(long userId);

		public Task<IEnumerable<dynamic>> GetPreferredRole(long userId);

		public Task<IEnumerable<dynamic>> GetJobTitles(string jobtitle);

		public Task<IEnumerable<dynamic>> GetAllJobTitles(string jobtitle = "");

		public Task<IEnumerable<dynamic>> GetJobInterviewByProfileId(long? jobId, long? profileId);

		public Task<IEnumerable<dynamic>> GetHirePersonInfo(long? userId);

		public Task<IEnumerable<dynamic>> GetInterviewSearch(string searchText, long? customerId);

		public Task<IEnumerable<dynamic>> GetjobAlertDetails(long userId, long jobAlertId);

		public Task<IEnumerable<dynamic>> GetJobAlerts(long userId, long jobAlertId);

		public Task<IEnumerable<dynamic>> GetJobViews(long jobId);

		public Task<IEnumerable<dynamic>> GetJobComments(long jobId);

		public Task<IEnumerable<dynamic>> GetSortNewProfiles(long customerId, long jobId, int statusId, int pageNumber, int noOfRows, int sortBy);

		public Task<IEnumerable<dynamic>> GetPreferredDoamin(long userId);

		public Task<IEnumerable<dynamic>> GetSavedSearch(long userId);

		public Task<IEnumerable<dynamic>> CustomerJobSearch(long? userId, string searchString, int? pageNumber, int pageSize = 10);

		public Task<IEnumerable<dynamic>> GetReferredList(long userId, long jobId);

		public Task<IEnumerable<dynamic>> GetApplictionHistory(long userId);

		public Task<IEnumerable<dynamic>> GetInterviewAcceptance(long userId, long jobId);

		public Task<IEnumerable<dynamic>> GetJobLocation(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobRequiredSkill(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobRequiredDomain(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobDomainsList(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobSkillsList(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobResponsibility(long? jobId);

		public Task<IEnumerable<dynamic>> GetEducationDetails(long? jobId);

		public Task<IEnumerable<dynamic>> GetInterviewList(Nullable<long> userId, Nullable<long> customerId, Nullable<int> month, Nullable<int> year, Nullable<int> sortBy, Nullable<int> pageNumber, Nullable<int> numberOfRows);

		public Task<IEnumerable<dynamic>> GetConversation(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobAccessTo(long? jobId);

		public Task<IEnumerable<dynamic>> GetPersonType(long? jobId);

		public Task<IEnumerable<dynamic>> GetConversationReply(long? conversationId);

		public Task<IEnumerable<dynamic>> GetJobCategory(string jobCategory);

		public Task<IEnumerable<dynamic>> GetDraftedJobs(long? customerId, long? userId);

		public Task<IEnumerable<dynamic>> SearchJobFilter(Nullable<long> customerId, Nullable<long> userId, Nullable<int> employmentTypeId, Nullable<int> experience, Nullable<int> cityId, Nullable<int> viewBy, Nullable<int> clientId, Nullable<int> departmentId, Nullable<int> pageNumber, Nullable<int> numberOfRows);

		public Task<IEnumerable<dynamic>> SuggestedJobTitles(long? customerId);

		public Task<IEnumerable<dynamic>> SuggestedJobCategory(long? customerId);

		public Task<IEnumerable<dynamic>> GetInterview(long? jobId);

		public Task<IEnumerable<dynamic>> GetCategory(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobClient(long? jobId);

		public Task<IEnumerable<dynamic>> GetJobDepartment(long? jobId);

		public Task<IEnumerable<dynamic>> GetCompanyNameList(string comapnyName);

		public Task<IEnumerable<dynamic>> GetCandidatePrimarySkillUpdated(long? jobId, long? profileId);

		public Task<IEnumerable<dynamic>> GetMissingSkills(int JobId, int ProfileId);

		public Task<IEnumerable<dynamic>> GetMissingDomains(int JobId, int ProfileId);

		public Task<IEnumerable<dynamic>> GetSkippedMissingSkills(int JobId, int ProfileId);

		public Task<IEnumerable<dynamic>> GetSkippedMissingDomains(int JobId, int ProfileId);

		public Task<IEnumerable<dynamic>> GetDashboardCustomerJob(long? customerId, long? userId);

		public Task<IEnumerable<dynamic>> GetCustomerJobList(long? customerId);

		public Task<IEnumerable<dynamic>> GetRoleFitJobDetailCustomer(long customerId, long jobId);

		public Task<IEnumerable<dynamic>> GetActiveJobs(string searchTerm, long customerId);

		//Post Methods

		public Task SearchCandidateProfiles(SearchProfileInput searchProfile);

		public Task SaveJobInfo(SaveJob saveJob);

		public Task SaveJobView(InsertDislikes insertView);

		public Task SaveJobFilter(Savefilter savefilter);

		public Task GetCandidateApproval(SaveJob approval);

		public Task GetCandidateApprovalById(SaveJob approval);

		public Task SaveJobComments(JobComments cmts);

		public Task InsertCandidateLike(CandidateLikes likes);

		public Task SaveJobLikes(InsertLikes likes);

		public Task InsertDisLikes(InsertDislikes disLikes);

		public Task AddJobPreferrence(JobPreferences jobPreferences);

		public Task AddJobAlert(InsertJobAlert jobalert);

		public Task UpdateCustomerInterviewAcceptance(UpdateInterview info);

		public Task UpdateInterviewAcceptance(InterviewAcceptance iaccept);

		public Task AddSaveSearch(Savesearch savesearch);

		public Task GetInterviewCalendar(InterviewCalendar calendar);

		public Task InsertConversation(SaveConversation savecon);

		public Task InsertJobRoles(InsertRoles roles);

		public Task UpdateMissingDomains(CandidateSkippedDomain CandidateSkippedDomains);


        //Delete Methods

        public Task DeleteCompanyContactDetails(long contactId);

        public Task DeleteJobFilter(long JobFilterId);

        public Task deleteCustomerPreferredLocation(long? preferredLocationId, long? customerId);

        public Task DeleteJobInfo(long? savedJobId);

        public Task DeleteJobComment(long? jobCommentId);

        public Task DeleteJobAlert(long? jobAlertId);

        public Task DeleteDraftedJob(long? jobId);

        public Task DeleteJobResponsibility(long? jobResponsibilityId);

        public Task DeleteJob(long? jobId);

    }
}
