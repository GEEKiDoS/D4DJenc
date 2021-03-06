namespace D4DJ_Tools.Masters
{
	public enum EventType
	{
		MouseDown = 0,
		MouseUp = 1,
		MouseMove = 2,
		MouseDrag = 3,
		KeyDown = 4,
		KeyUp = 5,
		ScrollWheel = 6,
		Repaint = 7,
		Layout = 8,
		DragUpdated = 9,
		DragPerform = 10,
		DragExited = 15,
		Ignore = 11,
		Used = 12,
		ValidateCommand = 13,
		ExecuteCommand = 14,
		ContextClick = 16,
		MouseEnterWindow = 20,
		MouseLeaveWindow = 21,
		mouseDown = 0,
		mouseUp = 1,
		mouseMove = 2,
		mouseDrag = 3,
		keyDown = 4,
		keyUp = 5,
		scrollWheel = 6,
		repaint = 7,
		layout = 8,
		dragUpdated = 9,
		dragPerform = 10,
		ignore = 11,
		used = 12,
	}

	public enum CampaignCategory
	{
		Mileage = 1,
	}

	public enum CardIllustType
	{
		Normal = 0,
		LimitBreak = 1,
		MaxLimitBreak = 2,
	}

	public enum ClubItemSpotCategory
	{
		Club = 1,
		DJ = 2,
		Stage = 3,
		Ceiling = 4,
	}

	public enum ClubItemTargetType
	{
		None = 0,
		Unit = 1,
		Attribute = 2,
		Parameter = 3,
		Character = 4,
		All = 5,
	}

	public enum CommonTextType
	{
		OptionPresetDescription = 101,
		OptionLaneViewRateDescription = 102,
		OptionPreBackColorDescription = 103,
		OptionLatencyDescription = 104,
		OptionTapTimingDescription = 105,
		OptionEvaluationModeDescription = 106,
		OptionMirrorDescription = 107,
		OptionSliderEffectDescription = 108,
		OptionEffectDescription = 109,
		OptionAutoColorDescription = 110,
		RatingDescription = 201,
		SetlistLiveResultScoreLogDefaultComment = 301,
		ShareLiveResult = 401,
		ShareSetlist = 402,
		ShareProfile = 403,
		SharePrivateRoom = 404,
		IssueTransferCode = 500,
		IssueTransferCodeComplete = 501,
		EpisodeUnlock = 502,
		IdSearch = 503,
		Help = 504,
		MusicDetail = 505,
		GiftReceiverSelect = 506,
		Option = 507,
		LiveOption = 508,
		SystemOption = 509,
		ProvidingRate = 510,
		SupportMemberUnlock = 511,
		ClubEffectConfirm = 512,
		ClubVisit = 513,
		FriendVisit = 514,
		Menu = 515,
		MusicReceivingHistory = 516,
		ModeSetting = 517,
		ConsumingSetting = 518,
		VoltageRecoveryConfirm = 519,
		ItemUseNumberSelect = 520,
		VoltageNotEnoughConfirm = 521,
		VoltageRecoveryMethodSelect = 522,
		UnlockCondition = 523,
		DeckRecommend = 524,
		LimitBreakResult = 525,
		HowToGet = 526,
		PurchaseError = 527,
		RegisterDateOfBirth = 528,
		Confirm = 529,
		PurchaseComplete = 530,
		ReadEpisode = 531,
		AcquiredRewards = 532,
		BingoCardConfirm = 533,
		RewardsConfirm = 534,
		VoltageConsumingConfirm = 535,
		CardCheck = 536,
		ExchangeNumberConfirm = 537,
		ExchangeNumberSelect = 538,
		MemberDetail = 539,
		GachaDetail = 540,
		ClubCustomizeRecommend = 541,
		Layout = 542,
		SetlistShare = 543,
		SetlistEdit = 544,
		GuestbookPosting = 545,
		Information = 546,
		LikeList = 547,
		MileageRank = 548,
		MileageRankUp = 549,
		MileageLoginBonus = 550,
		Present = 551,
		HonorDetail = 552,
		AutoMix = 553,
		FavoriteMusicSetting = 554,
		LiveResultMemberScoreMedley = 555,
		SetlistSave = 556,
		AchievementComplete = 557,
		CreatePrivateRoom = 558,
		JoinPrivateRoom = 559,
		GiftPurchaseConfirm = 560,
		SendingGift = 561,
		MusicPresentReceived = 562,
		MusicClearNumber = 563,
		ProfileSetting = 564,
		RankDetail = 565,
		AchievementCompleteRewardList = 566,
		EventRankNumber = 567,
		NotEnoughItems = 568,
		ClubItemList = 569,
		SetlistError = 570,
		LiveResultMemberScore = 571,
		MusicPresentReceivedFrom = 572,
		Rating = 573,
		UserRating = 574,
		ExpertLocked = 575,
		Error = 576,
		SendGiftComplete = 577,
		SendGiftError = 578,
		Nighttime = 579,
		Review = 580,
		Survey = 581,
		SupportMemberLocked = 582,
		Rehearsal = 583,
		TransferCodeRevokingConfirm = 584,
		VoltageRecovery = 585,
		Detail = 586,
		BingoCardSwitchConfirm = 587,
		InitializationConfirm = 588,
		InitializationComplete = 589,
		InputSucceed = 590,
		MVLocked = 591,
		Reset = 592,
		PasswordConfirm = 593,
		PurchaseConfirm = 594,
		Unit = 595,
		UnitEdit = 596,
		MemberChangeSelect = 597,
		Select = 598,
		CharacterIllustratedBook = 599,
		Album = 600,
		Profile = 601,
		CharacterSelect = 602,
		CharacterTop = 603,
		Shop = 604,
		DiamondShop = 605,
		Story = 606,
		ChapterSelect = 607,
		EventStorySelect = 608,
		UnitStorySelect = 609,
		StorySelect = 610,
		Event = 611,
		Ranking = 612,
		Rewards = 613,
		ChallengeMusicMedleySelect = 614,
		MultiInvestigationLive = 615,
		SoloInvestigationLive = 616,
		InvestigationLiveHistory = 617,
		ExchangeShop = 618,
		ExchangeShopSelect = 619,
		Friend = 620,
		List = 621,
		Gacha = 622,
		Result = 623,
		Club = 624,
		Customize = 625,
		MusicSelect = 626,
		ClubOf = 628,
		Honor = 629,
		UnitConfirm = 630,
		MedleyLive = 631,
		DifficultySelect = 632,
		Live = 633,
		LiveSelect = 634,
		FreeLive = 635,
		DJRoad = 636,
		GroovyMixToryumon = 637,
		PrivateLive = 638,
		RoomSelect = 639,
		MusicShop = 640,
		Others = 641,
		FavoriteStamps = 642,
		Settings = 643,
		Items = 644,
		ExpertLockedMusicHardSelected = 645,
		TransferCodeCopy = 646,
		TransferCodeCopyCompleted = 647,
		FriendRequestSent = 648,
		FriendDeleteConfirm = 649,
		FriendDeleted = 650,
		FriendRequestCancelConfirm = 651,
		FriendRequestCanceled = 652,
		FriendRequestApproveConfirm = 653,
		FriendRequestApproved = 654,
		FriendRequestRejectConfirm = 655,
		FriendRequestRejected = 656,
		IsOwnPlayerId = 657,
		GiftSentTo = 658,
		GiftPurchaseCanceledDueToAlreadyOwned = 659,
		NIghttimeMessage = 660,
		CannotRemoveMainUnitMember = 661,
		UnlockWhenPlayerRankAbove = 662,
		SetlistNotSet = 663,
		VoltageRecovered = 664,
		VoltageCanBeRecoveredUpTo = 665,
		MaxUpgraded = 666,
		RestoreCompleted = 667,
		RestartPendingPurchase = 668,
		PurchaseFailedDueToDuplicateTransaction = 669,
		PurchaseFailed = 670,
		CurrentBingoCardCompleted = 671,
		EventEnded = 672,
		PleaseWaitForResult = 673,
		ClubDeckInitialized = 674,
		CannotAutoMixDueToFilterSettings = 675,
		MusicOrderNotChangedByAutoMix = 676,
		CannotSwitchDueToFilterSettings = 677,
		MVNotUnlocked = 678,
		NoEventAvailableNow = 679,
		NetworkDisconnected = 680,
		PasswordIs = 681,
		WishlistLimitReached = 682,
		PlayerNameLengthLimit = 683,
		CommentLengthLimit = 684,
		Copied = 685,
		MusicPurchaseCanceledDueToBeingPresented = 686,
		AndroidDeviceCase = 687,
		LargeAudioLagAdjusted = 688,
		SliderEffectPartialOffConfirm = 689,
		CongratulateFullCombo = 690,
		ReviewRequest = 691,
		SurveyRequest = 692,
		DeepLinkConfirm = 693,
		LiveRetireConfirm = 694,
		RehearsalConfirm = 695,
		ReissueTransferCodeConfirm = 696,
		BoostTicketNotOwned = 697,
		BuyD4PASSToGetBoostTickets = 698,
		ProcessInterruptedDueToDateChanged = 699,
		UseSelectedItemsToRecoverVoltageConfirm = 700,
		ResetConfirm = 701,
		ConsumeItemsToUpgradeConfirm = 702,
		ClubDeckInitializeConfirm = 703,
		ClearMedleyConfirm = 704,
		OverwriteMedleyConfirm = 705,
		EndClubVisitConfirm = 706,
		ReturnToTitleConfirm = 707,
		ReturnWithoutSavingChangesConfirm = 708,
		LessionNotConsumeVoltage = 709,
		LessionShortage = 710,
		MVDownloadConfirm = 711,
		LessionLearnTechniqueConfirm = 712,
		SetFavoriteStampsConfirm = 713,
		InvalidDateOfBirth = 714,
		DateOfBirthAlreadyRegistered = 715,
		UnpauseLiveConfirm = 716,
		UnlockWhenAffectionAbove = 717,
		UnlockWhenLimitBreak = 718,
		DateOfBirthRegisterConfirm = 719,
		CannotBeChangedAfterwards = 720,
		MoveToNextBingoCardConfirm = 721,
		NotEnoughItemsMessage = 722,
		GoToDiamondShopConfirm = 723,
		ConsumItemsToPurchaseMusicConfirm = 724,
		ConsumeSpecifiedItemsFirst = 725,
		ConsumeDiamondsToRecoverVoltageConfirm = 726,
		ConsumeItemsToDrawGacha = 727,
		PasswordLimitation = 728,
		Decide = 729,
		ToStory = 730,
		Purchase = 731,
		SendGift = 732,
		ContentConfirm = 733,
		Recover = 734,
		ToNextCard = 735,
		Upgrade = 736,
		Post = 737,
		ToMileage = 738,
		Create = 739,
		Join = 740,
		Yes = 741,
		No = 742,
		Draw = 743,
		Close = 744,
		Retire = 745,
		Receive = 746,
		CheckD4PASS = 747,
		LimitBreak = 748,
		LiveStart = 749,
		WriteReview = 750,
		Start = 751,
		Reissue = 752,
		ToExchangeShop = 753,
		RestartAlone = 754,
		Restart = 755,
		Password = 756,
		Continue = 757,
		RemainingOneTime = 758,
		ScoreRank = 759,
		ComboCount = 760,
		ClearCount = 761,
		AchievedRewards = 762,
		Search = 763,
		UsersBeingRequested = 764,
		UsersPendingApproval = 765,
		FriendList = 766,
		RequestingList = 767,
		PendingApprovalList = 768,
		FriendSort = 769,
		AlreadyObtained = 770,
		BonusConfirm = 771,
		Apply = 772,
		CloseDetailSettings = 773,
		Open = 774,
		SkillLevel = 775,
		Remaining = 776,
		OutOfEventDate = 777,
		NoEventSpecificEffect = 778,
		EventSpecificEffect = 779,
		Edit = 780,
		Visit = 781,
		NoTimeLimit = 782,
		RecoverTensionDescription = 783,
		ComboSupportCountDescription = 784,
		ScoreUpDescription = 785,
		PerfectScoreUpDescription = 786,
		None = 787,
		RemainingXDays = 788,
		RemainingXHours = 789,
		RemainingXMinutes = 790,
		RemainingLessThanOneMinute = 791,
		MoreThanOneMonthAgo = 792,
		DaysAgo = 793,
		HoursAgo = 794,
		ResetAtDateEveryMonth = 795,
		ResetOnDayOfWeekEveryWeek = 796,
		ResetEveryDay = 797,
		UnsupportedType = 798,
		NoUpperLimit = 799,
		MemberOf = 800,
		AllOf = 801,
		MemberOfParameterUp = 802,
		Index = 803,
		PlayerRankAbove = 804,
		EventPointAbove = 805,
		EventEndDateInfo = 806,
		EventPoint = 807,
		Highscore = 808,
		Unknown = 809,
		PointRewards = 810,
		MultiLive = 811,
		MultiMedleyLive = 812,
		BattleLive = 813,
		Lyrist = 814,
		Composer = 815,
		Arranger = 816,
		MemberSortFilter = 817,
		SortFilter = 818,
		AreaMap = 819,
		TermsOfService = 820,
		PrivacyPolicy = 821,
		Achievement = 822,
		CompleteRewards = 823,
		SetConsumingCountToUpRewards = 824,
		RewardsMultiplied = 825,
		Stamps = 826,
		History = 827,
		BasicInformation = 828,
		Affection = 829,
		Training = 830,
		Room = 831,
		NoUseOf = 832,
		SkillUp = 833,
		TrainingMemberSelect = 834,
		SkillUpMemberSelect = 835,
		LimitBreakMemberSelect = 836,
		MemberList = 837,
		ToEvent = 838,
		ToGacha = 839,
		Unlocked = 840,
		Locked = 841,
		BeforeLimitBreak = 842,
		AfterLimitBreak = 843,
		NormalCard = 844,
		PremiumCard = 845,
		AlbumSortFilter = 846,
		PurchaseLimitReached = 847,
		Diamond = 848,
		SettlementAct = 849,
		TransactionsAct = 850,
		ExpireAt = 851,
		ToHome = 852,
		PackageContentConfirm = 853,
		CanGetAfterPurchasingXTimes = 854,
		MonthlyCharge = 855,
		Attentions = 856,
		ChapterNumber = 857,
		ReadPreviousEpisodes = 858,
		ReadEpisodeConfirm = 859,
		WithoutVoice = 860,
		WithVoice = 861,
		WithoutVoiceCalculating = 862,
		WithVoiceCalculating = 863,
		DownloadSize = 864,
		WithoutDownloading = 865,
		RaidBossNo = 866,
		RaidHpBonus = 867,
		NoRaidHpBonusYet = 868,
		NotJoinRanking = 869,
		MySelf = 870,
		RaidHpBonusDate = 871,
		RankingRewards = 872,
		DamageRanking = 873,
		PleaseWaitForTheNextTime = 874,
		HowToPlay = 875,
		UnlockWhenEventPointAbove = 876,
		PokerRoleList = 877,
		GotDamageRankingRewards = 878,
		Exchange = 879,
		Members = 880,
		ClubItems = 881,
		Music = 882,
		ExchangeDeadline = 883,
		ExchangeComplete = 884,
		Exchanged = 885,
		PickupMemberDuplicateBonus = 886,
		Required = 887,
		Owned = 888,
		GachaDescription = 889,
		UnderEditing = 890,
		Set = 891,
		ListItemBullet = 892,
		UnderSet = 893,
		Effect = 894,
		OfOwnClub = 895,
		ApplyClubItemEffectInLiveDescription = 896,
		ClubItemParameterUp = 897,
		PleaseChooseMedleyMusic = 898,
		IsPublic = 899,
		MakePublic = 900,
		CannotDueToHavingNotOwnedMusic = 901,
		MakePrivate = 902,
		UsersSentMeLikes = 903,
		UsersISentLikes = 904,
		ShowingNewest = 905,
		To = 906,
		NextMonthMileageRank = 907,
		From = 908,
		WhatIsMileage = 909,
		End = 910,
		NotReceived = 911,
		AlreadyReceived = 912,
		NoReceivablePresents = 913,
		NoReceivedPresentsSinceLastWeek = 914,
		ReceiveAllComplete = 915,
		ReceivedPresents = 916,
		SkillCastFrom = 917,
		SkillCast = 918,
		ResultAnnouncement = 919,
		UnderTallying = 920,
		PleaseChooseMusicAndDifficulty = 921,
		Next = 922,
		ToRoomSelect = 923,
		ToClub = 924,
		ToRaidBossSelect = 925,
		ToMusicSelect = 926,
		RaidBossNoIs = 927,
		RaidBossHpRemaining = 928,
		AffectionReachRewards = 929,
		VoltageRecoveryDescription = 930,
		DateTimeFromXToY = 931,
		OutOfDate = 932,
		Random = 933,
		Request = 934,
		Omakase = 935,
		Purchased = 936,
		NowAccepting = 937,
		Refuse = 938,
		ToMusicShop = 939,
		MusicPresent = 940,
		ProfileMemberChange = 941,
		FriendLimitAdnSupportMember = 942,
		FreeDiamond = 943,
		HonorIs = 944,
		MysteriousReward = 945,
		HasNobody = 946,
		EndAt = 947,
		All = 948,
		UnitRankAbove = 949,
		ClubItemLevelAbove = 950,
		ReadEpisodeOf = 951,
		HasNoItems = 952,
		ParameterUp = 953,
		AvailableFromListItem = 954,
		RemainingTimes = 955,
		WithoutVoiceSize = 956,
		WithVoiceSize = 957,
		RankingOf = 958,
		CanChallengeWhen = 959,
		RaidBossNumber = 960,
		Cancel = 961,
		Play = 962,
		BeginAt = 963,
		ReceiveComplete = 964,
		RaidBossBonusTitle = 965,
		RaidBossBonusMessage = 966,
		PleaseChooseUsingItems = 967,
		PleaseSetClubItems = 968,
		RewardsX = 969,
		XTimes = 970,
		SpaceSymbol = 971,
		LeftArrowSymbol = 972,
		SlashSymbol = 973,
		ColonSymbol = 974,
		CommaSymbol = 975,
		MusicNameWithBracket = 976,
		LoopTextOverflow = 977,
		ShowRoomKey = 978,
		HideRoomKey = 979,
		NotEnoughDeckPower = 980,
		CreateRoomDefaultComment = 981,
		RoomKeyDefaultText = 982,
		FindRoom = 983,
		ShowFriendRoom = 984,
		CreatePrivateRoomButton = 985,
		Private = 986,
		OpenPrivateRoom = 987,
		OpenedPrivateRoom = 988,
		WaitForJoinRoom = 989,
		HasInvitePrivateRoom = 990,
		SNSTransferUserNotFound = 999,
		TransferData = 1000,
		AppleIssueTransfer = 1001,
		AppleIssueTransferCompleted = 1002,
		AppleIssueTransferFailed = 1003,
		AppleIssueTransferCanceled = 1004,
		IssuedAppleID = 1005,
		ResetEveryXDay = 1006,
		Vote = 1007,
		HowManyToExchange = 1008,
		HowManyToVote = 1009,
		VoteNumberSelect = 1010,
		VoteNumberConfirm = 1011,
		PleaseConfirmExchangeNumber = 1012,
		PleaseConfirmVoteNumber = 1013,
		DJSimulatorFinishConfirm = 1014,
		DJSimulatorFinishConfirmNoReward = 1015,
		DJSimulatorStopConfirm = 1016,
		ExchangeNumber = 1017,
		VoteNumber = 1018,
		Level = 1019,
	}

	public enum CommonValueType
	{
		LiveSECount = 101,
		LiveNoteDesignCount = 102,
		LiveTapEffectCount = 103,
		LiveSliderLineCount = 104,
		LiveSliderArrowCount = 105,
		LiveContinueDiamondAmount = 106,
		LiveBoostMultiplier = 107,
		LikeEachTakeCount = 301,
		DJBoothGuestBookLatestListCount = 302,
		FriendRequestMaxCount = 303,
		PresentReceivedDayCount = 304,
		FavoriteStampMaxCount = 305,
		HonorMaxCount = 306,
		DJBoothSetlistMaxCount = 307,
		DJBoothGuestBookSetlistCount = 308,
		DJBoothGuestBookHighScoreListCount = 309,
		NicknameMaxLength = 401,
		CommentMaxLength = 402,
		CardDeckNameMaxLength = 403,
		ClubDeckNameMaxLength = 404,
		DJBoothSetlistTitleMaxLength = 405,
		MusicFavoriteDeckNameMaxLength = 406,
		DJBoothCommentMaxLength = 407,
		VoltageMaxAllowCount = 501,
		FirstTimeMusicId = 601,
		PrivateRoomCommentMaxLength = 701,
	}

	public enum ConditionCategory
	{
		None = 0,
		UserLevel = 1,
		UnitLevel = 2,
		ClubItem = 3,
		Story = 4,
		EventPoint = 5,
	}

	public enum EpisodeCategory
	{
		Unit = 1,
		Event = 2,
		Card = 3,
		LiveResult = 4,
		Map = 5,
		Tutorial = 9,
	}

	public enum BingoRewardCategory
	{
		Bingo = 0,
		Hit = 1,
		Complete = 2,
	}

	public enum BingoStatusCategory
	{
		Bingo = 0,
		Reach = 1,
		NoReach = 2,
	}

	public enum EventAggregationType
	{
		MainAddPoint = 0,
		Highscore = 1,
		AddPoint = 2,
		DailyAddPoint = 3,
	}

	public enum PokerHandCategory
	{
		RoyalStraightFlush = 0,
		StraightFlush = 1,
		FourOfAKind = 2,
		FullHouse = 3,
		Flush = 4,
		Straight = 5,
		ThreeOfAKind = 6,
		TwoPair = 7,
		OnePair = 8,
		HighCard = 9,
	}

	public enum DateSelectCategory
	{
		None = 0,
		Daily = 1,
		Weekly = 2,
		Monthly = 3,
	}

	public enum GachaType
	{
		Normal = 1,
		Tutorial = 2,
		Event = 3,
		Birthday = 4,
		Special = 5,
		Revival = 6,
	}

	public enum HonorType
	{
		Common = 0,
		Mission = 1,
		Character = 2,
		Event = 3,
		D4Pass = 4,
	}

	public enum Live2DUIChatCategory
	{
		MenuCommon = 0,
		LoginBonus = 1,
		Mission = 2,
		CharacterIntroduction = 3,
		GachaMenu = 4,
		BoxGacha = 5,
		Training = 6,
	}

	public enum ChartAchieveType
	{
		Score = 1,
		Combo = 2,
		ClearCount = 3,
	}

	public enum LiveType
	{
		Single = 0,
		Medley = 1,
		SingleBattle = 2,
	}

	public enum MultiRoomType
	{
		Free = 1,
		Beginner = 2,
		Veteran = 3,
		Master = 4,
	}

	public enum LoginBonusType
	{
		Common = 0,
		Campaign = 1,
		Subscription = 2,
		VipBronze = 3,
		VipSilver = 4,
		VipGold = 5,
		VipPlatinum = 6,
	}

	public enum MapEventType
	{
		Normal = 0,
		Special = 1,
		Birthday = 2,
	}

	public enum MapObjectType
	{
		Prefab = 0,
		Image = 1,
		Movie = 2,
	}

	public enum MobMovingPattern
	{
		Fixed = 0,
		OneWay = 1,
		Loop = 2,
	}

	public enum AchievementNotifyType
	{
		Default = 0,
		PokerHand = 1,
		BingoCard = 2,
	}

	public enum MissionCategory
	{
		Achievement = 0,
		Tutorial = 1,
		Chart = 2,
		TimeLimited = 3,
	}

	public enum ChartDifficulty
	{
		None = 0,
		Easy = 1,
		Normal = 2,
		Hard = 3,
		Expert = 4,
	}

	public enum ChartSectionType
	{
		Full = 0,
		Begin = 1,
		Middle = 2,
		End = 3,
		DJSimulator = 4,
	}

	public enum MusicCategory
	{
		None = 0,
		Original = 1,
		Cover = 2,
		Game = 3,
		Instrumental = 4,
		Collabo = 5,
	}

	public enum MileageRank
	{
		Normal = 0,
		Bronze = 1,
		Silver = 2,
		Gold = 3,
		Platinum = 4,
	}

	public enum StampCategory
	{
		Common = 0,
		Rare = 1,
		Collabo = 2,
	}

	public enum RewardCategory
	{
		Stock = 1,
		Card = 2,
		ClubItem = 3,
		Music = 4,
		Stamp = 5,
		Honor = 6,
		Episode = 7,
		Movie = 8,
	}

	public enum StockCategory
	{
		Diamond = 0,
		Fragment = 1,
		Exp = 2,
		SkillExp = 3,
		LimitBreak = 4,
		VoltageRecovery = 5,
		Boost = 6,
		MusicShop = 7,
		Event = 8,
		GachaTicket = 9,
		Random = 10,
		Point = 99,
	}

	public enum TrumpSuit
	{
		Club = 0,
		Diamond = 1,
		Heart = 2,
		Spade = 3,
	}

}
