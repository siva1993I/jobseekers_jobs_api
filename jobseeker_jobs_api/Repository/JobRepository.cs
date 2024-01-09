using Dapper;
using jobseeker_jobs_api.Context;
using jobseeker_jobs_api.Contracts;
using jobseeker_jobs_api.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace jobseeker_jobs_api.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly DapperContext _context;
        private string? customerjobquery;
        private string? jobStatsquery;
        public JobRepository(DapperContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<dynamic>> GetProcessingJob(long userId)
        {
            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<dynamic>("Usp_Get_ProcessingJob", new { userId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

		public async Task<IEnumerable<dynamic>> GetInterviewScheduledJobByProfileId(long profileId = 0, int pageNumber = 1, int pageSize = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_InterviewScheduledJobByProfileId", new { profileId, pageNumber, pageSize }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> RecentSearchInfo(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_RecentSearchDetailsInfo", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetProfileCount(long jobId, long customerId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_ProfileCount", new { jobId, customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCompanyName(string comapnyName)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_Company", new { comapnyName }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCompanyHeaderInfo(long customerId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CompanyLogo", new { customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobTitle(string jobtitle)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_JobTitle", new { jobtitle }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobs(long userId = 0, long customerId = 0, long jobId = 0, int sortBy = 0, int pageNumber = 1, int pageSize = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_Jobs", new { userId, customerId, jobId, sortBy, pageNumber, pageSize }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCustomerSummary(long? customerId, long? userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CustomerSummary", new { customerId, userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobSavedFilter(long? customerId, long? userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CustomerSavedFilteredJob", new { customerId, userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCustomerJobs(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? pageNumber, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CustomerJobsNew", new { customerId, userId, sortBy, searchString, status, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCustomerJobsUpdate(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? newSortBy, int? pageNumber, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_NewCustomerJobsLatest", new { customerId, userId, sortBy, searchString, status, newSortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCustomerFilteredJobs(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? pageNumber, int? minSal, int? maxSal, int? minExp, int? maxExp, string jobStatus, string locations, string skills, string clients, string departments, string titles, string domain, string immigration, string lastWeek, string lastTwoWeek, string last30days, string last90days, string lastyear, string today, string category, string empType, string education, string users, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CustomerFilteredJobUpdated", new { customerId, userId, sortBy, searchString, status,pageNumber, minSal, maxSal, minExp, maxExp, jobStatus, locations, skills, clients, departments, titles, domain, immigration, lastWeek, lastTwoWeek, last30days, last90days, lastyear, today, category, empType, education, users, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobBasicInfo(long? customerId, long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobBasicDetail", new { customerId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetOtherJob(long? customerId, long? userId, long? jobId, int? sortBy, int? pageNumber, int? numberOfRows)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_OtherJob", new { customerId, userId, jobId, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobsTemplate(long customerId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_Template", new { customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetApplicantsActivity(long userId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_OtherJob", new { userId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetInterviewJobs(long userId = 0, int pageNumber = 1, int pageSize = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_InterviewScheduledJob", new { userId, pageNumber, pageSize }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetShortlistedJobs(long userId = 0, int pageNumber = 1, int pageSize = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_ShortListedJob", new { userId, pageNumber, pageSize }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> DashboardSuggestedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int pageNumber = 1, int pageSize = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_DashboardSuggestedJob", new { userId, pageNumber, pageSize }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetInterviewSortBy(long? customerId, int? sortBy, int? listSort, string searchString, int? pageNumber, int? numberOfRows)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_InterviewSortByLatest", new { customerId, sortBy, listSort, searchString, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> SuggestedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_SuggestedJob", new { userId, fromDate, todate, statusId, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetReferrals(long userId, int quarterListId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_Referral", new { userId, quarterListId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> DashboardReferredJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int pageNumber = 1, int pageSize = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_DashboardReferredJob", new { userId, fromDate, todate, pageNumber, pageSize }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> RefferedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_ReferredJob", new { userId, fromDate, todate, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobActivity(long userId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobActivity", new { userId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> RefferedJobsToMe(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_ReferredToMe", new { userId, fromDate, todate, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> AppliedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, string monthly = null, string quarterly = null, int yearly = 0, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_AppliedJob", new { userId, fromDate, todate, monthly, quarterly, yearly, statusId, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobAssignedList(long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_RecruitingTeamOnJobId_Result", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobDetailCustomer(long customerId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_RecruitingTeamOnJobId_Result", new { customerId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobDetailCandidate(long jobId, long userId = 0)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobDetailsforCandidate", new { jobId, userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobDetailEmail(long jobId, long userId = 0)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobDetailsforCandidate", new { jobId, userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<ImageInfo>> GetImage(string imageLocation)
		{

			var query = "SELECT * FROM Images WHERE imageLocation = @imageLocation";

			var parameters = new DynamicParameters();
			parameters.Add("ImageId", imageLocation, DbType.String, ParameterDirection.Input);

			using (var connection = _context.CreateConnection())
			{
				var getImageLocation = await connection.QueryAsync<ImageInfo>(query, parameters);
				return getImageLocation;
			}
		}

		public async Task<IEnumerable<dynamic>> JobRefferedBy(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, string quarterly = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobReferredBy", new { userId, fromDate, todate, quarterly, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobRole(int functionalAreaId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobRole", new { functionalAreaId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetApplicantStatistics(long customerId, long userId, int filter)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_Applicant", new { customerId, userId, filter }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobStatistics(long? customerId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobStatistics", new { customerId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetApplicants(long customerId, long userId, int page, int numberofRows)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_RecentApplicant", new { customerId, userId, page, numberofRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetNotInterestedJobs(long userId, Nullable<int> statusId, int sortBy, int pageNumber, int numberOfRows)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_DislikedJob", new { userId, statusId, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetPendingJobs(long userId, Nullable<int> statusId, int sortBy, int pageNumber, int numberOfRows)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_PendingJobs1", new { userId, statusId, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCustomerPreferredLocation(long customerId, bool? isPostajob)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CustomerPreferredLocation", new { customerId, isPostajob }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobId(long referralId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobId", new { referralId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetNewProfiles(long customerId, long userId, long jobId, int statusId, int sortBy, string searchString, int? experience, string location, string domainName, int? uploaded, int? suggested, int? wishlist, int? invited, int? arytic, int pageNumber, int noOfRows, int FStatus)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("GetNewProfiles", new { customerId, userId, jobId, statusId, sortBy, searchString, experience, location, domainName, uploaded, suggested, wishlist, invited, arytic, pageNumber, noOfRows, FStatus }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetUserInfoByProfileMapping(long? profileId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_UserInfoByProfileMapping", new { profileId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetMatchingValueFromProfile(long? ProfileId, long? JobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobMatchingPerentage", new { ProfileId, JobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetSavedJobs(long userId = 0, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CandidateSavedJob", new { userId, statusId, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobPreference(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobPreference", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetAutoSearch(string searchText, long? customerId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_AutoSearch", new { searchText, customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCandidateRating(long userId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CandidateRating", new { userId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> JobMatchingPercentage(long userId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_MatchingPercentage", new { userId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetPreferredLocation(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_PreferredLocation", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetPreferredSkill(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_PreferredSkill", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetPreferredEmploymentType(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_PreferredEmploymentType", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetPreferredRole(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_PreferredRole", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobTitles(string jobtitle)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_JobTitle", new { jobtitle }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetAllJobTitles(string jobtitle = "")
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_AllJobTitleRefined", new { jobtitle }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobInterviewByProfileId(long? jobId, long? profileId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobInterviewByProfileId", new { jobId, profileId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetHirePersonInfo(long? userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_HirePersonInfo", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetInterviewSearch(string searchText, long? customerId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_InterviewSearch", new { searchText, customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetjobAlertDetails(long userId, long jobAlertId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobAlert", new { userId, jobAlertId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobAlerts(long userId, long jobAlertId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobAlert", new { userId, jobAlertId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobViews(long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobView", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobComments(long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobComment", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetSortNewProfiles(long customerId, long jobId, int statusId, int pageNumber, int noOfRows, int sortBy)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("MatchedProfileCount", new { customerId, jobId, statusId, pageNumber, noOfRows, sortBy }, commandType: CommandType.Text);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetPreferredDoamin(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_PreferredDomain", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetSavedSearch(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_SavedSearch", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> CustomerJobSearch(long? userId, string searchString, int? pageNumber, int pageSize = 10)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_CustomerJob", new { userId, searchString, pageNumber, pageSize = 10 }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetReferredList(long userId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_ReferredByList", new { userId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetApplictionHistory(long userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_ApplicationHistory", new { userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetInterviewAcceptance(long userId, long jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_InterviewAcceptance", new { userId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobLocation(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobLocation", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobRequiredSkill(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobRequiredSkill", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobRequiredDomain(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobRequiredDomain", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobDomainsList(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobRequiredDomain", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobSkillsList(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobRequiredSkill", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobResponsibility(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobResponsibility", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetEducationDetails(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_EducationDetails", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetInterviewList(Nullable<long> userId, Nullable<long> customerId, Nullable<int> month, Nullable<int> year, Nullable<int> sortBy, Nullable<int> pageNumber, Nullable<int> numberOfRows)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("GetInterviewList", new { userId, customerId, month, year, sortBy, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetConversation(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_Conversation", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobAccessTo(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobAccessTo", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetPersonType(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_PersonType", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetConversationReply(long? conversationId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_ConversationReply", new { conversationId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobCategory(string jobCategory)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_JobCategory", new { jobCategory }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetDraftedJobs(long? customerId, long? userId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_JobCategory", new { customerId, userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> SearchJobFilter(Nullable<long> customerId, Nullable<long> userId, Nullable<int> employmentTypeId, Nullable<int> experience, Nullable<int> cityId, Nullable<int> viewBy, Nullable<int> clientId, Nullable<int> departmentId, Nullable<int> pageNumber, Nullable<int> numberOfRows)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_JobFilter", new { customerId, userId, employmentTypeId, experience, cityId, viewBy, clientId, departmentId, pageNumber, numberOfRows }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> SuggestedJobTitles(long? customerId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Suggested_JobTitles", new { customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> SuggestedJobCategory(long? customerId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Suggested_JobCategory", new { customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetInterview(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_InterviewType", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCategory(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobCategory", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobClient(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobClient", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetJobDepartment(long? jobId)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobDepartment", new { jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCompanyNameList(string comapnyName)
		{
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_Company", new { comapnyName }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCandidatePrimarySkillUpdated(long? jobId, long? profileId)
		{
			
			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_CandidatePrimarySkillUpdated", new { jobId, profileId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetMissingSkills(int JobId, int ProfileId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Missing_Skills", new { JobId, ProfileId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetMissingDomains(int JobId, int ProfileId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Missing_Skills", new { JobId, ProfileId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetSkippedMissingSkills(int JobId, int ProfileId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_skipped_Missing_Skills", new { JobId, ProfileId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetSkippedMissingDomains(int JobId, int ProfileId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_skipped_Missing_Domains", new { JobId, ProfileId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetDashboardCustomerJob(long? customerId, long? userId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_DashboardCustomerJob", new { customerId, userId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetCustomerJobList(long? customerId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_Customer_JobList", new { customerId}, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetRoleFitJobDetailCustomer(long customerId, long jobId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Get_JobDetailforCustomer", new { customerId, jobId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		public async Task<IEnumerable<dynamic>> GetActiveJobs(string searchTerm, long customerId)
		{

			using (var connection = _context.CreateConnection())
			{
				var result = await connection.QueryAsync<dynamic>("Usp_Search_JobInformations", new { searchTerm, customerId }, commandType: CommandType.StoredProcedure);
				return result.ToList();
			}
		}

		//Post Methods
		public async Task SearchCandidateProfiles(SearchProfileInput searchProfile)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@CustomerId", searchProfile.CustomerId);
				parameters.Add("@JobId", searchProfile.JobId);
				parameters.Add("@SearchString", searchProfile.SearchString);
				parameters.Add("@Experience", searchProfile.Experience);
				parameters.Add("@QualificationId", searchProfile.QualificationId);
				parameters.Add("@Location", searchProfile.Location);
				parameters.Add("@PageNumber", searchProfile.PageNumber);
				parameters.Add("@NumberOfRows", searchProfile.NumberOfRows);

				await connection.QueryFirstOrDefault("Usp_Search_CandidateProfile", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task SaveJobInfo(SaveJob saveJob)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@UserId", saveJob.UserId);
				parameters.Add("@JobId", saveJob.JobId);
				
				await connection.QueryFirstOrDefault("Usp_Insert_CandidateSavedJob", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task SaveJobView(InsertDislikes insertView)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@jobId", insertView.jobId);
				parameters.Add("@userId", insertView.userId);

				await connection.QueryFirstOrDefault("Usp_Insert_JobView", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task SaveJobFilter(Savefilter savefilter)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@CustomerId", savefilter.CustomerId);
				parameters.Add("@UserId", savefilter.UserId);
				parameters.Add("@SortBy", savefilter.SortBy);
				parameters.Add("@MinSal", savefilter.MinSal);
				parameters.Add("@MaxSal", savefilter.MaxSal);
				parameters.Add("@MinExp", savefilter.MinExp);
				parameters.Add("@MaxExp", savefilter.MaxExp);
				parameters.Add("@JobStatus", savefilter.JobStatus);
				parameters.Add("@locations", savefilter.locations);
				parameters.Add("@skills", savefilter.skills);
				parameters.Add("@clients", savefilter.clients);
				parameters.Add("@titles", savefilter.titles);
				parameters.Add("@departments", savefilter.departments);
				parameters.Add("@domain", savefilter.domain);
				parameters.Add("@Immigration", savefilter.Immigration);
				parameters.Add("@lastWeek", savefilter.lastWeek);
				parameters.Add("@lastTwoWeek", savefilter.lastTwoWeek);
				parameters.Add("@last30days", savefilter.last30days);
				parameters.Add("@last90days", savefilter.last90days);
				parameters.Add("@lastyear", savefilter.lastyear);
				parameters.Add("@today", savefilter.today);
				parameters.Add("@category", savefilter.category);
				parameters.Add("@empType", savefilter.empType);
				parameters.Add("@education", savefilter.education);
				parameters.Add("@users", savefilter.users);
				
				await connection.QueryFirstOrDefault("Usp_Insert_SaveJobFilter", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task GetCandidateApproval(SaveJob approval)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@JobId", approval.JobId);
				parameters.Add("@UserId", approval.UserId);

				await connection.QueryFirstOrDefault("Usp_CandidateApproval", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task GetCandidateApprovalById(SaveJob approval)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@JobId", approval.JobId);
				parameters.Add("@UserId", approval.UserId);

				await connection.QueryFirstOrDefault("Usp_CandidateApprovalByProfileId", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task SaveJobComments(JobComments cmts)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@JobCommentId", cmts.JobCommentId);
				parameters.Add("@JobId", cmts.JobId);
				parameters.Add("@UserId", cmts.UserId);
				parameters.Add("@CommentText", cmts.CommentText);
				parameters.Add("@isPrivate", cmts.isPrivate);
				parameters.Add("@isDeleted", cmts.isDeleted);
			
				await connection.QueryFirstOrDefault("Usp_Insert_JobComment", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task InsertCandidateLike(CandidateLikes likes)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@CandidateLikeId", likes.CandidateLikeId);
				parameters.Add("@CustomerUserId", likes.CustomerUserId);
				parameters.Add("@CandidateUserId", likes.CandidateUserId);
				parameters.Add("@JobId", likes.JobId);
				parameters.Add("@IsLiked", likes.IsLiked);
				
				await connection.QueryFirstOrDefault("Usp_Insert_CandidateLike", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task SaveJobLikes(InsertLikes likes)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@jobId", likes.jobId);
				parameters.Add("@userId", likes.userId);
				parameters.Add("@isLiked", likes.isLiked);
				parameters.Add("@isPending", likes.isPending);
				
				await connection.QueryFirstOrDefault("Usp_Insert_JobLikes", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task InsertDisLikes(InsertDislikes disLikes)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@jobId", disLikes.jobId);
				parameters.Add("@userId", disLikes.userId);
				
				await connection.QueryFirstOrDefault("Usp_Insert_JobDislikes", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task AddJobPreferrence(JobPreferences jobPreferences)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@UserId", jobPreferences.UserId);
				parameters.Add("@RoleAlerts", jobPreferences.RoleAlerts);
				parameters.Add("@SkillAlerts", jobPreferences.SkillAlerts);
				parameters.Add("@LocationAlerts", jobPreferences.LocationAlerts);
				parameters.Add("@WorkInUs", jobPreferences.WorkInUs);
				parameters.Add("@VisaStatus", jobPreferences.VisaStatus);
				parameters.Add("@CurrentStatusId", jobPreferences.CurrentStatusId);
				parameters.Add("@RemoteWorkId", jobPreferences.RemoteWorkId);
				parameters.Add("@SalaryRangeId", jobPreferences.SalaryRangeId);
				parameters.Add("@BasicSalary", jobPreferences.BasicSalary);
				parameters.Add("@Relocation", jobPreferences.Relocation);
				parameters.Add("@Travel", jobPreferences.Travel);
				parameters.Add("@TravelPercentageId", jobPreferences.TravelPercentageId);
				parameters.Add("@TravelPercentage", jobPreferences.TravelPercentage);
				parameters.Add("@DruckCheck", jobPreferences.DruckCheck);
				parameters.Add("@WorkingHoursId", jobPreferences.WorkingHoursId);
				parameters.Add("@JobCategoryId", jobPreferences.JobCategoryId);
				parameters.Add("@EmploymentType", jobPreferences.EmploymentType);
				parameters.Add("@ProfileSearchable", jobPreferences.ProfileSearchable);
				parameters.Add("@CompanyListId", jobPreferences.CompanyListId);
				parameters.Add("@CompanySizeId", jobPreferences.CompanySizeId);
				parameters.Add("@MinimumSalary", jobPreferences.MinimumSalary);
				parameters.Add("@MaximumSalary", jobPreferences.MaximumSalary);
				parameters.Add("@XmlCompany", jobPreferences.XmlCompany);
				parameters.Add("@XmlCategory", jobPreferences.XmlCategory);
				parameters.Add("@XmlRole", jobPreferences.XmlRole);
				parameters.Add("@XmlSkill", jobPreferences.XmlSkill);
				parameters.Add("@XmlLocation", jobPreferences.XmlLocation);

				await connection.QueryFirstOrDefault("Usp_Insert_JobPreference", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task AddJobAlert(InsertJobAlert jobalert)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@jobAlertId", jobalert.jobAlertId);
				parameters.Add("@userId", jobalert.userId);
				parameters.Add("@jobAlertName", jobalert.jobAlertName);
				parameters.Add("@jobTitle", jobalert.jobTitle);
				parameters.Add("@jobRole", jobalert.jobRole);
				parameters.Add("@location", jobalert.location);
				parameters.Add("@experienceLevelId", jobalert.experienceLevelId);
				parameters.Add("@employmenttypeId", jobalert.employmenttypeId);
				parameters.Add("@domainId", jobalert.domainId);
				parameters.Add("@distance", jobalert.distance);
				parameters.Add("@subsciptionTypeId", jobalert.subsciptionTypeId);
				parameters.Add("@alertRequired", jobalert.alertRequired);
				parameters.Add("@scheduleTypeId", jobalert.scheduleTypeId);
				
				await connection.QueryFirstOrDefault("Usp_Insert_JobAlert", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task UpdateCustomerInterviewAcceptance(UpdateInterview info)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@CustomerId", info.CustomerId);
				parameters.Add("@UserId", info.UserId);
				parameters.Add("@JobId", info.JobId);
				parameters.Add("@IsCandidateAccepted", info.IsCandidateAccepted);
				parameters.Add("@IsCPNewDate", info.IsCPNewDate);
				parameters.Add("@CPDate", info.CPDate);
				parameters.Add("@CPFromTime", info.CPFromTime);
				
				await connection.QueryFirstOrDefault("Usp_Update_CustomerInteriewAccept", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task UpdateInterviewAcceptance(InterviewAcceptance iaccept)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@userId", iaccept.userId);
				parameters.Add("@jobId", iaccept.jobId);			
				parameters.Add("@IsCandidateAccepted", iaccept.IsCandidateAccepted);
				parameters.Add("@IsCPNewDate", iaccept.IsCPNewDate);
				parameters.Add("@CPDate", iaccept.CPDate);
				parameters.Add("@CPFromTime", iaccept.CPFromTime);
				parameters.Add("@CPToTime", iaccept.CPToTime);
				parameters.Add("@CandidateComments", iaccept.CandidateComments);

				await connection.QueryFirstOrDefault("Usp_Update_InterviewAcceptance", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task AddSaveSearch(Savesearch savesearch)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@UserId", savesearch.UserId);
				parameters.Add("@SavedSearchTitle", savesearch.SavedSearchTitle);
				parameters.Add("@JobTitle", savesearch.JobTitle);
				parameters.Add("@Location", savesearch.Location);
				parameters.Add("@EmploymentTypeId", savesearch.EmploymentTypeId);
				parameters.Add("@distanceId", savesearch.distanceId);
				parameters.Add("@postedOn", savesearch.postedOn);
				parameters.Add("@domainId", savesearch.domainId);
				parameters.Add("@experienceLevelId", savesearch.experienceLevelId);
				parameters.Add("@minimumSalary", savesearch.minimumSalary);
				parameters.Add("@maximumSalary", savesearch.maximumSalary);
				parameters.Add("@Flag", savesearch.Flag);

				await connection.QueryFirstOrDefault("Usp_Insert_SavedSearch", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task GetInterviewCalendar(InterviewCalendar calendar)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@UserId", calendar.UserId);
				parameters.Add("@CustomerId", calendar.CustomerId);
				parameters.Add("@StartDate", calendar.StartDate);
				parameters.Add("@EndDate", calendar.EndDate);
				parameters.Add("@Month", calendar.Month);
				parameters.Add("@Year", calendar.Year);
				parameters.Add("@SortBy", calendar.SortBy);
				parameters.Add("@PageNumber", calendar.PageNumber);
				parameters.Add("@NumberOfRows", calendar.NumberOfRows);
				
				await connection.QueryFirstOrDefault("Usp_Get_InterviewCalendar", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task InsertConversation(SaveConversation savecon)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@conversationId", savecon.conversationId);
				parameters.Add("@jobId", savecon.jobId);
				parameters.Add("@senderId", savecon.senderId);
				parameters.Add("@receiverId", savecon.receiverId);
				parameters.Add("@replyText", savecon.replyText);
				parameters.Add("@isRead", savecon.isRead);
				parameters.Add("@isDeleted", savecon.isDeleted);
				
				await connection.QueryFirstOrDefault("Usp_Insert_Conversation", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task InsertJobRoles(InsertRoles roles)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@UserId", roles.UserId);
				parameters.Add("@JobId", roles.JobId);
				parameters.Add("@XmlRoles", roles.XmlRoles);
				
				await connection.QueryFirstOrDefault("Usp_Insert_JobRoles", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public async Task UpdateMissingDomains(CandidateSkippedDomain CandidateSkippedDomains)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@ProfileId", CandidateSkippedDomains.ProfileId);
				parameters.Add("@JobId", CandidateSkippedDomains.JobId);
				parameters.Add("@DomainId", CandidateSkippedDomains.DomainId);
				parameters.Add("@CreatedOn", CandidateSkippedDomains.CreatedOn);
				parameters.Add("@CreatedBy", CandidateSkippedDomains.CreatedBy);
				parameters.Add("@ModifiedOn", CandidateSkippedDomains.ModifiedOn);
				parameters.Add("@ModifiedBy", CandidateSkippedDomains.ModifiedBy);
				parameters.Add("@IsUpdated", CandidateSkippedDomains.IsUpdated);
				parameters.Add("@DomainName", CandidateSkippedDomains.DomainName);

				await connection.QueryFirstOrDefault("CandidateSkippedDomains", parameters, commandType: CommandType.StoredProcedure);
			}
		}

        //Delete Methods

        public async Task DeleteCompanyContactDetails(long contactId)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ContactId", contactId);
                
                await connection.ExecuteAsync("Usp_Delete_CompanyContactDetails", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteJobFilter(long JobFilterId)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@JobFilterId", JobFilterId);

                await connection.ExecuteAsync("Usp_Delete_JobFilter", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task deleteCustomerPreferredLocation(long? preferredLocationId, long? customerId)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PreferredLocationId", preferredLocationId);
                parameters.Add("@CustomerId", customerId);

                await connection.ExecuteAsync("Usp_Delete_CustomerPreferredLocation", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteJobInfo(long? savedJobId)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@SavedJobId", savedJobId);
               
                await connection.ExecuteAsync("Usp_Delete_CandidateSavedJob", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteJobComment(long? jobCommentId)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@JobCommentId", jobCommentId);

                await connection.ExecuteAsync("Usp_Delete_JobComment", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteJobAlert(long? jobAlertId)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@JobAlertId", jobAlertId);

                await connection.ExecuteAsync("Usp_Delete_JobAlert", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteDraftedJob(long? jobId)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@JobId", jobId);

                await connection.ExecuteAsync("Usp_Delete_DraftedJob", parameters, commandType: CommandType.StoredProcedure);
            }
        }

		public async Task DeleteJobResponsibility(long? jobResponsibilityId)
		{
			using (var connection = _context.CreateConnection())
			{
				var parameters = new DynamicParameters();
				parameters.Add("@JobResponsibilityId", jobResponsibilityId);

				await connection.ExecuteAsync("Usp_Delete_JobResponsibility", parameters, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
