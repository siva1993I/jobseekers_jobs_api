
using jobseeker_jobs_api.Repository;
using jobseeker_jobs_api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Globalization;
using jobseeker_jobs_api.Entities;

namespace jobseeker_jobs_api.Controllers
{
    [Route("api")]
    [ApiController]
    public class JobController  : ControllerBase
    {
        private readonly IJobRepository _jobRepo;

        public JobController(IJobRepository jobRepo)
        {
            _jobRepo = jobRepo;
        }
 

        [HttpGet("GetProcessingJob")]
        public async Task<IActionResult> GetProcessingJob(long userId)
        {
            try
            {
                var result = await _jobRepo.GetProcessingJob(userId);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

		[HttpGet("GetJobsSelectedForInterviewbyProfileId")]
		public async Task<IActionResult> GetInterviewScheduledJobByProfileId(long profileId = 0, int pageNumber = 1, int pageSize = 10)
		{
			try
			{
				var result = await _jobRepo.GetInterviewScheduledJobByProfileId(profileId, pageNumber, pageSize);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetRecentSearchInfo")]
		public async Task<IActionResult> GetRecentSearchInfo(long userId)
		{
			try
			{
				var result = await _jobRepo.RecentSearchInfo(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetProfileCount")]
		public async Task<IActionResult> GetProfileCount(long jobId, long customerId)
		{
			try
			{
				var result = await _jobRepo.GetProfileCount(jobId, customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}
			

		[HttpGet("GetCompanyNames")]
		public async Task<IActionResult> GetCompanyName(string comapnyName)
		{
			try
			{
				var result = await _jobRepo.GetCompanyName(comapnyName);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCompanyHeaderInfo")]
		public async Task<IActionResult> GetCompanyHeaderInfo(long customerId)
		{
			try
			{
				var result = await _jobRepo.GetCompanyHeaderInfo(customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobTitles")]
		public async Task<IActionResult> GetJobTitle(string jobtitle)
		{
			try
			{
				var result = await _jobRepo.GetJobTitle(jobtitle);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobs")]
		public async Task<IActionResult> GetJobs(long userId = 0, long customerId = 0, long jobId = 0, int sortBy = 0, int pageNumber = 1, int pageSize = 10)
		{
			try
			{
				var result = await _jobRepo.GetJobs(userId, customerId, jobId, sortBy, pageNumber, pageSize);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCustomerSummary")]
		public async Task<IActionResult> GetCustomerSummary(long? customerId, long? userId)
		{
			try
			{
				var result = await _jobRepo.GetCustomerSummary(customerId, userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobSavedFilter")]
		public async Task<IActionResult> GetJobSavedFilter(long? customerId, long? userId)
		{
			try
			{
				var result = await _jobRepo.GetJobSavedFilter(customerId, userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}


		[HttpGet("GetCustomerJobs")]
		public async Task<IActionResult> GetCustomerJobs(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? pageNumber, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.GetCustomerJobs(customerId, userId, sortBy, searchString, status, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCustomerJobsUpdate")]
		public async Task<IActionResult> GetCustomerJobsUpdate(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? newSortBy, int? pageNumber, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.GetCustomerJobsUpdate(customerId, userId, sortBy, searchString, status, newSortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCustomerFilteredJobs")]
		public async Task<IActionResult> GetCustomerFilteredJobs(long? customerId, long? userId, int? sortBy, string searchString, int? status, int? pageNumber, int? minSal, int? maxSal, int? minExp, int? maxExp, string jobStatus, string locations, string skills, string clients, string departments, string titles, string domain, string immigration, string lastWeek, string lastTwoWeek, string last30days, string last90days, string lastyear, string today, string category, string empType, string education, string users, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.GetCustomerFilteredJobs(customerId, userId, sortBy, searchString, status, pageNumber, minSal, maxSal, minExp, maxExp, jobStatus, locations, skills, clients, departments, titles, domain, immigration, lastWeek, lastTwoWeek, last30days, last90days, lastyear, today, category, empType, education, users, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobBasicInfo")]
		public async Task<IActionResult> GetJobBasicInfo(long? customerId, long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobBasicInfo(customerId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetOtherJob")]
		public async Task<IActionResult> GetOtherJob(long? customerId, long? userId, long? jobId, int? sortBy, int? pageNumber, int? numberOfRows)
		{
			try
			{
				var result = await _jobRepo.GetOtherJob(customerId, userId, jobId, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobsTemplate")]
		public async Task<IActionResult> GetJobsTemplate(long customerId)
		{
			try
			{
				var result = await _jobRepo.GetJobsTemplate(customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetApplicantsActivity")]
		public async Task<IActionResult> GetApplicantsActivity(long userId, long jobId)
		{
			try
			{
				var result = await _jobRepo.GetApplicantsActivity(userId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobsSelectedForInterview")]
		public async Task<IActionResult> GetInterviewJobs(long userId = 0, int pageNumber = 1, int pageSize = 10)
		{
			try
			{
				var result = await _jobRepo.GetInterviewJobs(userId, pageNumber, pageSize);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetShortlistedJobs")]
		public async Task<IActionResult> GetShortlistedJobs(long userId = 0, int pageNumber = 1, int pageSize = 10)
		{
			try
			{
				var result = await _jobRepo.GetShortlistedJobs(userId, pageNumber, pageSize);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("DashboardSuggestedJobs")]
		public async Task<IActionResult> DashboardSuggestedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int pageNumber = 1, int pageSize = 10)
		{
			try
			{
				var result = await _jobRepo.DashboardSuggestedJobs(userId, fromDate, todate, pageNumber, pageSize);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("InterviewSortBy")]
		public async Task<IActionResult> GetInterviewSortBy(long? customerId, int? sortBy, int? listSort, string searchString, int? pageNumber, int? numberOfRows)
		{
			try
			{
				var result = await _jobRepo.GetInterviewSortBy(customerId, sortBy, listSort, searchString, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("SuggestedJobs")]
		public async Task<IActionResult> SuggestedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.SuggestedJobs(userId, fromDate, todate, statusId, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetReferrals")]
		public async Task<IActionResult> GetReferrals(long userId, int quarterListId)
		{
			try
			{
				var result = await _jobRepo.GetReferrals(userId, quarterListId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("DashboardRefferedJobs")]
		public async Task<IActionResult> DashboardRefferedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int pageNumber = 1, int pageSize = 10)
		{
			try
			{
				var result = await _jobRepo.DashboardReferredJobs(userId, fromDate, todate, pageNumber, pageSize);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}


		[HttpGet("RefferedJobs")]
		public async Task<IActionResult> RefferedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.RefferedJobs(userId, fromDate, todate, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobActivity")]
		public async Task<IActionResult> GetJobActivity(long userId, long jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobActivity(userId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("RefferedJobsToMe")]
		public async Task<IActionResult> RefferedJobsToMe(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.RefferedJobsToMe(userId, fromDate, todate, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("AppliedJobs")]
		public async Task<IActionResult> AppliedJobs(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, string monthly = null, string quarterly = null, int yearly = 0, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.AppliedJobs(userId, fromDate, todate, monthly, quarterly, yearly, statusId, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}


		[HttpGet("GetJobAssignedList")]
		public async Task<IActionResult> GetJobAssignedList(long jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobAssignedList(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobDetailCustomer")]
		public async Task<IActionResult> GetJobDetailCustomer(long customerId, long jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobDetailCustomer(customerId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobDetailCandidate")]
		public async Task<IActionResult> GetJobDetailCandidate(long jobId, long userId = 0)
		{
			try
			{
				var result = await _jobRepo.GetJobDetailCandidate(jobId, userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobDetailEmail")]
		public async Task<IActionResult> GetJobDetailEmail(long jobId, long userId = 0)
		{
			try
			{
				var result = await _jobRepo.GetJobDetailEmail(jobId, userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetImage")] //NO SP
		public async Task<IActionResult> GetImage(string imageLocation)
		{
			try
			{
				var result = await _jobRepo.GetImage(imageLocation);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("JobsRefferredBy")]
		public async Task<IActionResult> JobsRefferredBy(long userId = 0, DateTime? fromDate = null, DateTime? todate = null, string quarterly = null, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)	
		{
			try
			{
				var result = await _jobRepo.JobRefferedBy(userId, fromDate, todate, quarterly, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobRole")]
		public async Task<IActionResult> GetJobRole(int functionalAreaId)
		{
			try
			{
				var result = await _jobRepo.GetJobRole(functionalAreaId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetApplicantStatistics")]
		public async Task<IActionResult> GetApplicantStatistics(long customerId, long userId, int filter)
		{
			try
			{
				var result = await _jobRepo.GetApplicantStatistics(customerId, userId, filter);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobStatistics")]
		public async Task<IActionResult> GetJobStatistics(long? customerId, long jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobStatistics(customerId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetApplicants")]
		public async Task<IActionResult> GetApplicants(long customerId, long userId, int page, int numberofRows)
		{
			try
			{
				var result = await _jobRepo.GetApplicants(customerId, userId, page, numberofRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("NotInterestedJobs")]
		public async Task<IActionResult> GetDislikesJobs(long userId, Nullable<int> statusId, int sortBy, int pageNumber, int numberOfRows)
		{
			try
			{
				var result = await _jobRepo.GetNotInterestedJobs(userId, statusId, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPendingJobs")]
		public async Task<IActionResult> GetPendingJobs(long userId, Nullable<int> statusId, int sortBy, int pageNumber, int numberOfRows)
		{
			try
			{
				var result = await _jobRepo.GetPendingJobs(userId, statusId, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCustomerPreferredLocation")]
		public async Task<IActionResult> GetCustomerPreferredLocation(long customerId, bool? isPostajob)
		{
			try
			{
				var result = await _jobRepo.GetCustomerPreferredLocation(customerId, isPostajob);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobId")]
		public async Task<IActionResult> GetJobId(long referralId)
		{
			try
			{
				var result = await _jobRepo.GetJobId(referralId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetProfiles")]
		public async Task<IActionResult> GetNewProfiles(long customerId, long userId, long jobId, int statusId, int sortBy, string searchString, int? experience, string location, string domainName, int? uploaded, int? suggested, int? wishlist, int? invited, int? arytic, int pageNumber, int noOfRows, int FStatus)
		{
			try
			{
				var result = await _jobRepo.GetNewProfiles(customerId, userId, jobId, statusId, sortBy, searchString, experience, location, domainName, uploaded, suggested, wishlist, invited, arytic, pageNumber, noOfRows,FStatus);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetUserInfoByProfileMapping")]
		public async Task<IActionResult> GetUserInfoByProfileMapping(long? profileId)
		{
			try
			{
				var result = await _jobRepo.GetUserInfoByProfileMapping(profileId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobMatchingProfileId")]
		public async Task<IActionResult> GetJobMatchingProfileId(long? ProfileId, long? JobId)
		{
			try
			{
				var result = await _jobRepo.GetMatchingValueFromProfile(ProfileId, JobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("SavedJobsInfo")]
		public async Task<IActionResult> SavedJobsInfo(long userId = 0, int statusId = 0, int sortBy = 0, int pageNumber = 1, int numberOfRows = 10)
		{
			try
			{
				var result = await _jobRepo.GetSavedJobs(userId, statusId, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}


		[HttpGet("GetJobPreference")]
		public async Task<IActionResult> GetJobPreference(long userId)
		{
			try
			{
				var result = await _jobRepo.GetJobPreference(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}


		[HttpGet("GetAutoSearch")]
		public async Task<IActionResult> GetAutoSearch(string searchText, long? customerId)
		{
			try
			{
				var result = await _jobRepo.GetAutoSearch(searchText, customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCandidateRating")]
		public async Task<IActionResult> GetCandidateRating(long userId, long jobId)
		{
			try
			{
				var result = await _jobRepo.GetCandidateRating(userId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobMatchingPercentage")]
		public async Task<IActionResult> JobMatchingPercentage(long userId, long jobId)
		{
			try
			{
				var result = await _jobRepo.JobMatchingPercentage(userId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPreferredLocation")]
		public async Task<IActionResult> GetPreferredLocation(long userId)
		{
			try
			{
				var result = await _jobRepo.GetPreferredLocation(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPreferredSkill")]
		public async Task<IActionResult> GetPreferredSkill(long userId)
		{
			try
			{
				var result = await _jobRepo.GetPreferredSkill(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPreferredEmploymentType")]
		public async Task<IActionResult> GetPreferredEmploymentType(long userId)
		{
			try
			{
				var result = await _jobRepo.GetPreferredEmploymentType(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPreferredRole")]
		public async Task<IActionResult> GetPreferredRole(long userId)
		{
			try
			{
				var result = await _jobRepo.GetPreferredRole(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCandidateJobTitles")]
		public async Task<IActionResult> GetJobTitles(string jobtitle)
		{
			try
			{
				var result = await _jobRepo.GetJobTitles(jobtitle);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetAllJobTitles")]
		public async Task<IActionResult> GetAllJobTitles(string jobtitle = "")
		{
			try
			{
				var result = await _jobRepo.GetAllJobTitles(jobtitle);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobInterviewByProfileId")]
		public async Task<IActionResult> GetJobInterviewByProfileId(long? jobId, long? profileId)
		{
			try
			{
				var result = await _jobRepo.GetJobInterviewByProfileId(jobId, profileId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetHirePersonInfo")]
		public async Task<IActionResult> GetHirePersonInfo(long? userId)
		{
			try
			{
				var result = await _jobRepo.GetHirePersonInfo(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetInterviewSearch")]
		public async Task<IActionResult> GetInterviewSearch(string searchText, long? customerId)
		{
			try
			{
				var result = await _jobRepo.GetInterviewSearch(searchText, customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetjobAlertDetails")]
		public async Task<IActionResult> GetjobAlertDetails(long userId, long jobAlertId)
		{
			try
			{
				var result = await _jobRepo.GetjobAlertDetails(userId, jobAlertId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobAlerts")]
		public async Task<IActionResult> GetJobAlerts(long userId, long jobAlertId)
		{
			try
			{
				var result = await _jobRepo.GetJobAlerts(userId, jobAlertId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobViews")]
		public async Task<IActionResult> GetJobViews(long jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobViews(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobComments")]
		public async Task<IActionResult> GetJobComments(long jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobComments(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetSortNewApplicants")]
		public async Task<IActionResult> GetSortNewProfiles(long customerId, long jobId, int statusId, int pageNumber, int noOfRows, int sortBy)
		{
			try
			{
				var result = await _jobRepo.GetSortNewProfiles(customerId, jobId, statusId, pageNumber, noOfRows, sortBy);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPreferredDomain")]
		public async Task<IActionResult> GetPreferredDomain(long userId)
		{
			try
			{
				var result = await _jobRepo.GetPreferredDoamin(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetSavedSearch")]
		public async Task<IActionResult> GetSavedSearch(long userId)
		{
			try
			{
				var result = await _jobRepo.GetSavedSearch(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("CustomerJobSearch")]
		public async Task<IActionResult> CustomerJobSearch(long? userId, string searchString, int? pageNumber, int pageSize = 10)
		{
			try
			{
				var result = await _jobRepo.CustomerJobSearch(userId, searchString, pageNumber, pageSize = 10);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetReferredByList")]
		public async Task<IActionResult> GetReferredByList(long userId, long jobId)
		{
			try
			{
				var result = await _jobRepo.GetReferredList(userId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetApplicationHistory")]
		public async Task<IActionResult> GetApplicationHistory(long userId)
		{
			try
			{
				var result = await _jobRepo.GetApplictionHistory(userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetInterviewAcceptance")]
		public async Task<IActionResult> GetInterviewAcceptance(long userId, long jobId)
		{
			try
			{
				var result = await _jobRepo.GetInterviewAcceptance(userId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobLocation")]
		public async Task<IActionResult> GetJobLocation(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobLocation(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobRequiredSkill")]
		public async Task<IActionResult> GetJobRequiredSkill(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobRequiredSkill(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobRequiredDomain")]
		public async Task<IActionResult> GetJobRequiredDomain(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobRequiredDomain(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}


		[HttpGet("GetJobDomains")]
		public async Task<IActionResult> GetJobDomains(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobDomainsList(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobSkills")]
		public async Task<IActionResult> GetJobSkills(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobSkillsList(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobResponsibility")]
		public async Task<IActionResult> GetJobResponsibility(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobResponsibility(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetEducationDetails")]
		public async Task<IActionResult> GetEducationDetails(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetEducationDetails(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetInterviewList")]
		public async Task<IActionResult> GetInterviewList(Nullable<long> userId, Nullable<long> customerId, Nullable<int> month, Nullable<int> year, Nullable<int> sortBy, Nullable<int> pageNumber, Nullable<int> numberOfRows)
		{
			try
			{
				var result = await _jobRepo.GetInterviewList(userId, customerId, month, year, sortBy, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetConversation")]
		public async Task<IActionResult> GetConversation(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetConversation(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobAccessTo")]
		public async Task<IActionResult> GetJobAccessTo(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobAccessTo(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPersonType")]
		public async Task<IActionResult> GetPersonType(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetPersonType(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetConversationReply")]
		public async Task<IActionResult> GetConversationReply(long? conversationId)
		{
			try
			{
				var result = await _jobRepo.GetConversationReply(conversationId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobCategory")]
		public async Task<IActionResult> GetJobCategory(string jobCategory)
		{
			try
			{
				var result = await _jobRepo.GetJobCategory(jobCategory);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetDraftedJobs")]
		public async Task<IActionResult> GetDraftedJobs(long? customerId, long? userId)
		{
			try
			{
				var result = await _jobRepo.GetDraftedJobs(customerId, userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("SearchJobFilter")]
		public async Task<IActionResult> SearchJobFilter(Nullable<long> customerId, Nullable<long> userId, Nullable<int> employmentTypeId, Nullable<int> experience, Nullable<int> cityId, Nullable<int> viewBy, Nullable<int> clientId, Nullable<int> departmentId, Nullable<int> pageNumber, Nullable<int> numberOfRows)
		{
			try
			{
				var result = await _jobRepo.SearchJobFilter(customerId, userId, employmentTypeId, experience, cityId, viewBy, clientId, departmentId, pageNumber, numberOfRows);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("SuggestedJobTitles")]
		public async Task<IActionResult> SuggestedJobTitles(long? customerId)
		{
			try
			{
				var result = await _jobRepo.SuggestedJobTitles(customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("SuggestedJobCategory")]
		public async Task<IActionResult> SuggestedJobCategory(long? customerId)
		{
			try
			{
				var result = await _jobRepo.SuggestedJobCategory(customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetInterviewScheduleType")]
		public async Task<IActionResult> GetInterview(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetInterview(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetDraftCategory")]
		public async Task<IActionResult> GetCategory(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetCategory(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobClient")]
		public async Task<IActionResult> GetJobClient(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobClient(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetJobDepartment")]
		public async Task<IActionResult> GetJobDepartment(long? jobId)
		{
			try
			{
				var result = await _jobRepo.GetJobDepartment(jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetPrefferedCompanyNames")]
		public async Task<IActionResult> GetCompanyNameList(string comapnyName)
		{
			try
			{
				var result = await _jobRepo.GetCompanyNameList(comapnyName);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCandidatePrimarySkillUpdated")]
		public async Task<IActionResult> GetCandidatePrimarySkillUpdated(long? jobId, long? profileId)
		{
			try
			{
				
				var result = await _jobRepo.GetCandidatePrimarySkillUpdated(jobId, profileId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetMissingSkills")]
		public async Task<IActionResult> GetMissingSkills(int JobId, int ProfileId)
		{
			try
			{

				var result = await _jobRepo.GetMissingSkills(JobId, ProfileId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetMissingDomains")]
		public async Task<IActionResult> GetMissingDomains(int JobId, int ProfileId)
		{
			try
			{

				var result = await _jobRepo.GetMissingDomains(JobId, ProfileId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetSkippedMissingSkills")]
		public async Task<IActionResult> GetSkippedMissingSkills(int JobId, int ProfileId)
		{
			try
			{

				var result = await _jobRepo.GetSkippedMissingSkills(JobId, ProfileId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetSkippedMissingDomains")]
		public async Task<IActionResult> GetSkippedMissingDomains(int JobId, int ProfileId)
		{
			try
			{

				var result = await _jobRepo.GetSkippedMissingDomains(JobId, ProfileId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetDashboardCustomerJob")]
		public async Task<IActionResult> GetDashboardCustomerJob(long? customerId, long? userId)
		{
			try
			{

				var result = await _jobRepo.GetDashboardCustomerJob(customerId, userId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetCustomerJobList")]
		public async Task<IActionResult> GetCustomerJobList(long? customerId)
		{
			try
			{

				var result = await _jobRepo.GetCustomerJobList(customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetRoleFitJobDetailCustomer")]
		public async Task<IActionResult> GetRoleFitJobDetailCustomer(long customerId, long jobId)
		{
			try
			{

				var result = await _jobRepo.GetRoleFitJobDetailCustomer(customerId, jobId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("GetActiveJobs")]
		public async Task<IActionResult> GetActiveJobs(string searchTerm, long customerId)
		{
			try
			{

				var result = await _jobRepo.GetActiveJobs(searchTerm, customerId);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}


		//Post Methods
		[HttpPost]
		[Route("SearchCandidateProfiles")]
		public async Task<IActionResult> SearchCandidateProfiles(SearchProfileInput searchProfile)
		{
			try
			{
				await _jobRepo.SearchCandidateProfiles(searchProfile);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveJobInfo")]
		public async Task<IActionResult> SaveJobInfo(SaveJob saveJob)
		{
			try
			{
				await _jobRepo.SaveJobInfo(saveJob);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveJobView")]
		public async Task<IActionResult> SaveJobView(InsertDislikes insertView)
		{
			try
			{
				await _jobRepo.SaveJobView(insertView);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveJobFilter")]
		public async Task<IActionResult> SaveJobFilter(Savefilter savefilter)
		{
			try
			{
				await _jobRepo.SaveJobFilter(savefilter);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("GetCandidateApproval")]
		public async Task<IActionResult> GetCandidateApproval(SaveJob approval)
		{
			try
			{
				await _jobRepo.GetCandidateApproval(approval);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("GetCandidateApprovalById")]
		public async Task<IActionResult> GetCandidateApprovalById(SaveJob approval)
		{
			try
			{
				await _jobRepo.GetCandidateApproval(approval);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveJobComments")]
		public async Task<IActionResult> SaveJobComments(JobComments cmts)
		{
			try
			{
				await _jobRepo.SaveJobComments(cmts);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveCandidateLike")]
		public async Task<IActionResult> InsertCandidateLike(CandidateLikes likes)
		{
			try
			{
				await _jobRepo.InsertCandidateLike(likes);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveJobLikes")]
		public async Task<IActionResult> SaveJobLikes(InsertLikes likes)
		{
			try
			{
				await _jobRepo.SaveJobLikes(likes);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveJobDisLikes")]
		public async Task<IActionResult> SaveJobDisLikes(InsertDislikes disLikes)
		{
			try
			{
				await _jobRepo.InsertDisLikes(disLikes);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("InsertJobPreferrence")]
		public async Task<IActionResult> InsertJobPreferrence(JobPreferences jobPreferences)
		{
			try
			{
				await _jobRepo.AddJobPreferrence(jobPreferences);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("InsertJobAlertInfo")]
		public async Task<IActionResult> InsertJobAlertInfo(InsertJobAlert jobalert)
		{
			try
			{
				await _jobRepo.AddJobAlert(jobalert);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("UpdateCustomerInterviewAcceptance")]
		public async Task<IActionResult> UpdateCustomerInterviewAcceptance(UpdateInterview info)
		{
			try
			{
				await _jobRepo.UpdateCustomerInterviewAcceptance(info);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}


		[HttpPost]
		[Route("UpdateInterviewAcceptance")]
		public async Task<IActionResult> UpdateInterviewAcceptance(InterviewAcceptance iaccept)
		{
			try
			{
				await _jobRepo.UpdateInterviewAcceptance(iaccept);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("InsertSaveSearch")]
		public async Task<IActionResult> InsertSaveSearch(Savesearch savesearch)
		{
			try
			{
				await _jobRepo.AddSaveSearch(savesearch);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("GetInterviewCalendar")]
		public async Task<IActionResult> GetInterviewCalendar(InterviewCalendar calendar)
		{
			try
			{
				await _jobRepo.GetInterviewCalendar(calendar);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("InsertConversation")]
		public async Task<IActionResult> InsertConversation(SaveConversation savecon)
		{
			try
			{
				await _jobRepo.InsertConversation(savecon);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("SaveJobRoles")]
		public async Task<IActionResult> InsertJobRoles(InsertRoles roles)
		{
			try
			{
				await _jobRepo.InsertJobRoles(roles);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		[Route("UpdateMissingDomains")]
		public async Task<IActionResult> UpdateMissingDomains(CandidateSkippedDomain CandidateSkippedDomains)
		{
			try
			{
				await _jobRepo.UpdateMissingDomains(CandidateSkippedDomains);
				return Ok(new { Success = true });

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		
		//Delete Methods

        [HttpDelete]
        [Route("DeleteCompanyContacts")]
        public async Task<IActionResult> DeleteCompanyContacts(long contactId)
        {
            try
            {
                await _jobRepo.DeleteCompanyContactDetails(contactId);
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteJobFilter")]
        public async Task<IActionResult> DeleteJobFilter(long JobFilterId)
        {
            try
            {
                await _jobRepo.DeleteJobFilter(JobFilterId);
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteCustomerPreferredLocation")]
        public async Task<IActionResult> DeleteCustomerPreferredLocation(long? preferredLocationId, long? customerId)
        {
            try
            {
                await _jobRepo.deleteCustomerPreferredLocation(preferredLocationId, customerId);
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteSavedJobInfo")]
        public async Task<IActionResult> DeleteSavedJobInfo(long? savedJobId)
        {
            try
            {
                await _jobRepo.DeleteJobInfo(savedJobId);
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteJobComment")]
        public async Task<IActionResult> DeleteJobComment(long? jobCommentId)
        {
            try
            {
                await _jobRepo.DeleteJobComment(jobCommentId);
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteJobalert")]
        public async Task<IActionResult> DeleteJobAlert(long? jobAlertId)
        {
            try
            {
                await _jobRepo.DeleteJobAlert(jobAlertId);
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteDraftedJob")]
        public async Task<IActionResult> DeleteDraftedJob(long? jobId)
        {
            try
            {
                await _jobRepo.DeleteDraftedJob(jobId);
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

		[HttpDelete]
		[Route("DeleteJobResponsibility")]
		public async Task<IActionResult> DeleteJobResponsibility(long? jobResponsibilityId)
		{
			try
			{
				await _jobRepo.DeleteJobResponsibility(jobResponsibilityId);
				return NoContent();

			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}


	}
}
