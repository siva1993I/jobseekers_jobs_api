namespace jobseeker_jobs_api.Entities
{
	public class MatchingParameterDetails
	{
		public decimal? Role { get; set; }
		public bool? isPublic { get; set; }
		public decimal? TotalExp { get; set; }
		public decimal? Domain { get; set; }
		public decimal? Experience { get; set; }
		public decimal? Rating { get; set; }
		public decimal? Skillfit_Total { get; set; }

		public decimal? Personalityfit { get; set; }

		public long? CultureFit { get; set; }

		public decimal? JobFit { get; set; }


		public decimal? SkillFit { get; set; }

		public decimal? Jobfit_Total { get; set; }
		public decimal? Personalityfit_Total { get; set; }
		public decimal Total_Match_Per { get; set; }



	}
}
