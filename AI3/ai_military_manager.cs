float armyRatio(int value = 0)
{
	if(value < 20)
	{
		return(0.13);
	}
	else if(value < 25)
	{
		return(0.16);
	}
	else if(value < 30)
	{
		return(0.19);
	}
	else if(value < 35)
	{
		return(0.22);
	}
	else if(value < 40)
	{
		return(0.25);
	}
	else if(value < 45)
	{
		return(0.28);
	}
	else if(value < 50)
	{
		return(0.31);
	}
	else if(value < 55)
	{
		return(0.34);
	}
	else if(value < 60)
	{
		return(0.37);
	}
	else
	{
		return(0.4);
	}
	return(0.0);
}

void armyTrain()
{
	if(aiTreatyActive() == true)return;
	int mainCav = -1;
	int mainCavlow = -1;
	int antiCav = -1;
	int mainArt = -1;
	int mainArtlow = -1;
	int mainArtAnti = -1;
	int mainINF = -1;
	int mainINFlow = -1;
	int antiHI = -1;
	int antiHIlow = -1;
	int antiLI = -1;
	int antiLIlow = -1;
	int antiLC = -1;
	int antiLClow = -1;
	int antiCAVINF = -1;
	int antiCAVlow = -1;
	int baseCavAnti = -1;
	int mainNativeWarrior = -1;
	int mainMercenary = -1;
	
	static int mainCavPlan = -1;
	static int mainCavlowPlan = -1;
	static int antiCavPlan = -1;
	static int mainArtPlan = -1;
	static int mainArtlowPlan = -1;
	static int mainArtAntiPlan = -1;
	static int mainINFPlan = -1;
	static int mainINFlowPlan = -1;
	static int antiHIPlan = -1;
	static int antiHILowPlan = -1;
	static int antiLIPlan = -1;
	static int antiLIlowPlan = -1;
	static int antiLCPlan = -1;
	static int antiLClowPlan = -1;
	static int antiCAVINFPlan = -1;
	static int antiCAVlowPlan = -1;
	static int baseCavAntiPlan = -1;
	static int mainNativeWarriorPlan = -1;
	static int mainMercenaryPlan = -1;
	
	if ( mainCavPlan != -1 ) aiPlanDestroy(mainCavPlan);
	if ( mainCavlowPlan != -1 ) aiPlanDestroy(mainCavlowPlan);
	if ( antiCavPlan != -1 ) aiPlanDestroy(antiCavPlan);
	if ( mainArtPlan != -1 ) aiPlanDestroy(mainArtPlan);
	if ( mainArtlowPlan != -1 ) aiPlanDestroy(mainArtlowPlan);
	if ( mainArtAntiPlan != -1 ) aiPlanDestroy(mainArtAntiPlan);
	if ( mainINFPlan != -1 ) aiPlanDestroy(mainINFPlan);
	if ( mainINFlowPlan != -1 ) aiPlanDestroy(mainINFlowPlan);
	if ( antiHIPlan != -1 ) aiPlanDestroy(antiHIPlan);
	if ( antiHILowPlan != -1 ) aiPlanDestroy(antiHILowPlan);
	if ( antiLIPlan != -1 ) aiPlanDestroy(antiLIPlan);
	if ( antiLIlowPlan != -1 ) aiPlanDestroy(antiLIlowPlan);
	if ( antiLCPlan != -1 ) aiPlanDestroy(antiLCPlan);
	if ( antiLClowPlan != -1 ) aiPlanDestroy(antiLClowPlan);
	if ( antiCAVINFPlan != -1 ) aiPlanDestroy(antiCAVINFPlan);
	if ( antiCAVlowPlan != -1 ) aiPlanDestroy(antiCAVlowPlan);
	if ( baseCavAntiPlan != -1 ) aiPlanDestroy(baseCavAntiPlan);
	if ( mainNativeWarriorPlan != -1 ) aiPlanDestroy(mainNativeWarriorPlan);
	if ( mainMercenaryPlan != -1 ) aiPlanDestroy(mainMercenaryPlan);
	
	
	float mainCavValue = 0.0;
	float mainCavlowValue = 0.0;
	float antiCavValue = 0.0;
	float mainArtValue = 0.0;
	float mainArtlowValue = 0.0;
	float mainArtAntiValue = 0.0;
	float mainINFValue = 0.0;
	float mainINFlowValue = 0.0;
	float antiHIValue = 0.0;
	float antiHILowValue = 0.0;
	float antiLIValue = 0.0;
	float antiLIlowValue = 0.0;
	float antiLCValue = 0.0;
	float antiLClowValue = 0.0;
	float antiCAVINFValue = 0.0;
	float antiCAVlowValue = 0.0;
	float baseCavAntiValue = 0.0;
	float mainNativeWarriorValue = 0.0;
	float mainMercenaryValue = 0.0;
	
	switch (kbGetCiv())
	{
		case cCivFrench:
		{
			mainCav = cUnitTypeHussar;
			mainCavlow = cUnitTypeHussar;
			antiCav = cUnitTypeDragoon;		
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;	
			mainINF = cUnitTypeMusketeer;
			mainINFlow = cUnitTypeMusketeer;
			antiHI = cUnitTypeSkirmisher;
			antiHIlow = cUnitTypeCrossbowman;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeMusketeer;
			antiLC = cUnitTypeSkirmisher;
			antiLClow = cUnitTypeCrossbowman;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeMusketeer;
			baseCavAnti = cUnitTypePikeman;
			
			if(kbGetAge() > cAge3)
			{
				antiHIlow = cUnitTypeSkirmisher;
				antiLClow = cUnitTypeSkirmisher;
				mainCav = cUnitTypeCuirassier;
				mainINF = cUnitTypeMusketeer;
			}
			
			break;
		}
		case cCivJapanese:
		{
			mainCav = cUnitTypeypNaginataRider;
			mainCavlow = cUnitTypeypNaginataRider;
			antiCav = cUnitTypeypYabusame;		
			mainArt = cUnitTypeypFlamingArrow;	
			mainArtlow = cUnitTypeypFlamingArrow;
			mainArtAnti = cUnitTypeypFlamingArrow;	
			mainINF = cUnitTypeypAshigaru;
			mainINFlow = cUnitTypeypAshigaru;
			antiHI = cUnitTypeypYumi;
			antiHIlow = cUnitTypeypYumi;
			antiLI = cUnitTypeSohei;
			antiLIlow = cUnitTypeSohei;
			antiLC = cUnitTypeypKensei;
			antiLClow =cUnitTypeypKensei;
			antiCAVINF = cUnitTypeypKensei;
			antiCAVlow = cUnitTypeypKensei;
			baseCavAnti = cUnitTypeypKensei;
			break;
		}
		case cCivSpanish:
		{
			mainCav = cUnitTypeLancer;
			mainCavlow = cUnitTypeHussar;
			antiCav = cUnitTypeDragoon;		
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;
			mainINF = cUnitTypeRodelero;
			mainINFlow = cUnitTypeMusketeer;
			antiHI = cUnitTypeSkirmisher;
			antiHIlow = cUnitTypeCrossbowman;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeMusketeer;
			antiLC = cUnitTypeSkirmisher;
			antiLClow = cUnitTypeCrossbowman;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeMusketeer;
			baseCavAnti = cUnitTypePikeman;
			
			if(kbGetAge() > cAge3)
			{
				antiHIlow = cUnitTypeSkirmisher;
				antiLClow = cUnitTypeSkirmisher;
			}	
			
			break;
		}
		case cCivBritish:
		{
			mainCav = cUnitTypeHussar;
			mainCavlow = cUnitTypeHussar;
			antiCav = cUnitTypeDragoon;		
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;		
			mainINF = cUnitTypeHalberdier;
			mainINFlow = cUnitTypeMusketeer;
			antiHI = cUnitTypeGrenadier;
			antiHIlow = cUnitTypeLongbowman;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeMusketeer;
			antiLC = cUnitTypeLongbowman;
			antiLClow = cUnitTypeLongbowman;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeMusketeer;
			baseCavAnti = cUnitTypePikeman;
			break;
		}
		
		case cCivPortuguese:
		{
			mainCav = cUnitTypeCavalaria; // Main Cavalry:
			mainCavlow = cUnitTypeCavalaria; // Main Cavalry (low):
			antiCav = cUnitTypeDragoon;		// Counter Cavalry Cavalry (low):
			mainArt = cUnitTypexpHorseArtillery; //Main Artillery:
			mainArtlow = cUnitTypeOrganGun; // Main Artillery (low):
			mainArtAnti = cUnitTypeCulverin; //Counter Artillery (low):
			mainINF = cUnitTypeHalberdier; //Main Infantry:
			mainINFlow = cUnitTypeMusketeer; //Main Infantry (low): Trooper
			antiHI = cUnitTypeCacadore; //Light Infantry: Patrol Mechs (maybe Assault too)
			antiHIlow = cUnitTypeCrossbowman; //Light Infantry (low): Sniper-class
			antiLI = cUnitTypePikeman; //Counter Light Infantry: Counter Mechs
			antiLIlow = cUnitTypeMusketeer; //Counter Light Infantry (low): Missile-class
			antiLC = cUnitTypeCacadore; //Counter Light Cavalry: Anti-Air
			antiLClow = cUnitTypeCrossbowman; //Counter Light Cavalry (Low): Interceptor
			antiCAVINF = cUnitTypePikeman; // Counter Cavalry Infantry: Missile-class
			antiCAVlow = cUnitTypeMusketeer; //Counter Cavalry Infantry (low): 
			baseCavAnti = cUnitTypePikeman; //Basic Counter Cavalry
			
			if(kbGetAge() > cAge3)
			{
				antiHIlow = cUnitTypeCacadore;
				antiLClow = cUnitTypeCacadore;
			}
			break;
		}
		case cCivDutch:
		{	
			mainCav = cUnitTypeHussar;
			mainCavlow = cUnitTypeHussar;
			antiCav = cUnitTypeRuyter;		
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;		
			mainINF = cUnitTypeHalberdier;
			mainINFlow = cUnitTypeSchutze;
			antiHI = cUnitTypeGrenadier;
			antiHIlow = cUnitTypeSkirmisher;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeSchutze;
			antiLC = cUnitTypeSkirmisher;
			antiLClow = cUnitTypeSkirmisher;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeSchutze;
			baseCavAnti = cUnitTypePikeman;
			break;
		}
		case cCivRussians:
		{
			mainCav = cUnitTypeOprichnik;
			mainCavlow = cUnitTypeCossack;
			antiCav = cUnitTypeCavalryArcher;		
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;
			mainINF = cUnitTypeHalberdier;
			mainINFlow = cUnitTypeMusketeer;
			antiHI = cUnitTypeGrenadier;
			antiHIlow = cUnitTypeStrelet;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeMusketeer;
			antiLC = cUnitTypeMusketeer;
			antiLClow = cUnitTypeStrelet;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeMusketeer;
			baseCavAnti = cUnitTypePikeman;
			break;
		}
		case cCivGermans:
		{	
			mainCav = cUnitTypeWarWagon;
			mainCavlow = cUnitTypeUhlan;
			antiCav = cUnitTypeWarWagon;		
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;		
			mainINF = cUnitTypeDopplesoldner;
			mainINFlow = cUnitTypeDopplesoldner;
			antiHI = cUnitTypeSkirmisher;
			antiHIlow = cUnitTypeCrossbowman;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeDopplesoldner;
			antiLC = cUnitTypeSkirmisher;
			antiLClow = cUnitTypeCrossbowman;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeDopplesoldner;
			baseCavAnti = cUnitTypePikeman;
			
			if(kbGetAge() > cAge3)
			{
				antiHIlow = cUnitTypeSkirmisher;
				antiLClow = cUnitTypeSkirmisher;
			}
			break;
		}
		
		case cCivOttomans:
		{
			mainCav = cUnitTypeSpahi;
			mainCavlow = cUnitTypeHussar;
			antiCav = cUnitTypeCavalryArcher;		
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;			
			mainINF = cUnitTypeAzap;
			mainINFlow = cUnitTypeJanissary;
			antiHI = cUnitTypeAbusGun;
			antiHIlow = cUnitTypeJanissary;
			antiLI = cUnitTypeGrenadier;
			antiLIlow = cUnitTypeJanissary;
			antiLC = cUnitTypeAbusGun;
			antiLClow = cUnitTypeJanissary;
			antiCAVINF = cUnitTypeJanissary;
			antiCAVlow = cUnitTypeGrenadier;
			baseCavAnti = cUnitTypeJanissary;		
			break;
		}
		case cCivXPIroquois:
		{
			mainCav = cUnitTypexpHorseman;
			mainCavlow = cUnitTypexpHorseman;
			antiCav = cUnitTypexpMusketRider;	
			mainArt = cUnitTypexpLightCannon;
			mainArtlow = cUnitTypexpLightCannon;
			mainArtAnti = cUnitTypexpLightCannon;		
			mainINF = cUnitTypexpAenna;
			mainINFlow = cUnitTypexpMantlet;
			antiHI = cUnitTypexpMusketWarrior;
			antiHIlow = cUnitTypexpMantlet;
			antiLI = cUnitTypexpTomahawk;
			antiLIlow = cUnitTypexpMantlet;
			antiLC = cUnitTypexpMusketWarrior;
			antiLClow = cUnitTypexpMantlet;
			antiCAVINF = cUnitTypexpTomahawk;
			antiCAVlow = cUnitTypexpMantlet;
			baseCavAnti = cUnitTypexpTomahawk;
			break;
		}
		case cCivXPSioux:
		{	
			mainCav = cUnitTypexpAxeRider;
			mainCavlow = cUnitTypexpBowRider;
			antiCav = cUnitTypexpRifleRider;		
			mainArt = cUnitTypexpCoupRider;
			mainArtlow = cUnitTypexpCoupRider;
			mainArtAnti = cUnitTypexpAxeRider;	
			mainINF = cUnitTypexpWarClub;
			mainINFlow = cUnitTypexpWarRifle;
			antiHI = cUnitTypexpWarRifle;
			antiHIlow = cUnitTypexpWarBow;
			antiLI = cUnitTypexpWarClub;
			antiLIlow = cUnitTypexpWarRifle;
			antiLC = cUnitTypexpWarRifle;
			antiLClow = cUnitTypexpWarBow;
			antiCAVINF = cUnitTypexpWarClub;
			antiCAVlow = cUnitTypexpWarRifle;
			baseCavAnti = cUnitTypexpWarClub;
			break;
		}
		case cCivXPAztec:
		{
			mainCav = cUnitTypeNatHuaminca;
			mainCavlow = cTechEliteCoyotemen;
			antiCav = cUnitTypexpEagleKnight;			
			mainArt = cUnitTypexpCoupRider;
			mainArtlow = cUnitTypexpCoupRider;
			mainArtAnti = cUnitTypexpArrowKnight;			
			mainINF = cUnitTypexpPumaMan;
			mainINFlow = cUnitTypexpJaguarKnight;
			antiHI = cUnitTypexpJaguarKnight;
			antiHIlow = cUnitTypexpMacehualtin;
			antiLI = cTechEliteCoyotemen;
			antiLIlow = cUnitTypexpJaguarKnight;
			antiLC = cUnitTypexpJaguarKnight;
			antiLClow = cUnitTypexpMacehualtin;
			antiCAVINF = cTechEliteCoyotemen;
			antiCAVlow = cUnitTypexpJaguarKnight;
			baseCavAnti = cTechEliteCoyotemen;
			if(kbGetAge() > cAge3)
			{
				mainINF = cUnitTypexpJaguarKnight;
			}
			break;
		}
		
		case cCivUSA:
		{
			mainCav = cUnitTypeSaber;
			mainCavlow = cUnitTypeSaber;
			antiCav = cUnitTypeMountedRifleman;	
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;	
			mainINF = cUnitTypeUSColonialMarines;
			mainINFlow = cUnitTypeUSColonialMarines;
			antiHI = cUnitTypeUSColonialMilitia;
			antiHIlow = cUnitTypeGrenadier; 
			antiLI = cUnitTypeUSGatlingGuns; 
			antiLIlow = cUnitTypeUSColonialMarines;
			antiLC = cUnitTypeUSRiflemenRegiment;
			antiLClow = cUnitTypeUSColonialMarines;
			antiCAVINF = cUnitTypeUSColonialMarines;
			antiCAVlow = cUnitTypeUSColonialMarines;
			baseCavAnti = cUnitTypeUSColonialMarines;
			
			if(kbGetAge() > cAge3)
			{
				antiHI = cUnitTypeGrenadier;
			}
			break;
		}
		case cCivSwedish:
		{
			mainCav = cUnitTypePistolS;
			mainCavlow = cUnitTypeHussar;
			antiCav = cUnitTypeDragoon;	
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;		
			mainINF = cUnitTypeHandgonne;
			mainINFlow = cUnitTypeMusketeer;
			antiHI = cUnitTypeSharpshooter;
			antiHIlow = cUnitTypeMusketeer;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeMusketeer;
			antiLC = cUnitTypeSharpshooter;
			antiLClow = cUnitTypeMusketeer;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeMusketeer;
			baseCavAnti = cUnitTypePikeman;
			
			if(kbGetAge() > cAge3)
			{
				antiHIlow = cUnitTypeSharpshooter;
				antiLClow = cUnitTypeSharpshooter;
			}
			break;
		}
		case cCivItalians:
		{
			mainCav = cUnitTypeHussar;
			mainCavlow = cUnitTypeHussar;
			antiCav = cUnitTypeMountedCrossbowman;
			mainArt = cUnitTypexpHorseArtillery;
			mainArtlow = cUnitTypeFalconet;
			mainArtAnti = cUnitTypeCulverin;	
			mainINF = cUnitTypeMusketeer;
			mainINFlow = cUnitTypeMusketeer;
			antiHI = cUnitTypeSaker;
			antiHIlow = cUnitTypeFlatbowman;
			antiLI = cUnitTypePikeman;
			antiLIlow = cUnitTypeMusketeer;
			antiLC = cUnitTypeSkirmisher;
			antiLClow = cUnitTypeFlatbowman;
			antiCAVINF = cUnitTypePikeman;
			antiCAVlow = cUnitTypeMusketeer;
			baseCavAnti = cUnitTypePikeman;
			break;
		}
		case cCivIndians:
		{
			mainCav = cUnitTypeypSowarMansabdar;
			mainCavlow = cUnitTypeypSowarMansabdar;
			antiCav = cUnitTypeypZamburak;	
			mainArt = cUnitTypeypMercFlailiphantMansabdar;
			mainArtlow = cUnitTypeypMercFlailiphantMansabdar;
			mainArtAnti = cUnitTypeypSiegeElephantMansabdar;
			mainINF = cUnitTypeypUrumi;
			mainINFlow = cUnitTypeypIGCSepoy;
			antiHI = cUnitTypeypNatMercGurkha;
			antiHIlow = cUnitTypeypIGCSepoy;
			antiLI = cUnitTypeypMahoutMansabdar;
			antiLIlow = cUnitTypeypMahoutMansabdar;
			antiLC = cUnitTypeypNatMercGurkha;
			antiLClow = cUnitTypeypIGCSepoy;
			antiCAVINF = cUnitTypeypHowdahMansabdar;
			antiCAVlow = cUnitTypeypHowdahMansabdar;
			baseCavAnti = cUnitTypeypRajput;
			break;
		}
		case cCivChinese:
		{
			mainCav = cUnitTypeypForbiddenArmy;
			mainCavlow = cUnitTypeypBlackFlagArmy;
			antiCav = cUnitTypeypMongolianArmy;			
			mainArt = cUnitTypeypFlameThrower;
			mainArtlow = cUnitTypeypFlameThrower;
			mainArtAnti = cUnitTypeypHandMortar;	
			mainINF = cUnitTypeypTerritorialArmy;
			mainINFlow = cUnitTypeypStandardArmySpawn;
			antiHI = cUnitTypeypImperialArmy;
			antiHIlow = cUnitTypeypOldHanArmy;
			antiLI = cUnitTypeypMingArmy;
			antiLIlow = cUnitTypeypStandardArmySpawn;
			antiLC = cUnitTypeypImperialArmy;
			antiLClow = cUnitTypeypOldHanArmy;
			antiCAVINF = cUnitTypeypMingArmy;
			antiCAVlow = cUnitTypeypStandardArmySpawn;
			baseCavAnti = cUnitTypeypMingArmy;	
			
			if(kbGetAge() > cAge3)
			{
				mainINFlow = cUnitTypeypTerritorialArmy;
				antiHIlow = cUnitTypeypTerritorialArmy;
				antiLI = cUnitTypeypImperialArmy;
				antiLIlow = cUnitTypeypTerritorialArmy;
				antiLClow =cUnitTypeypTerritorialArmy;
				antiCAVINF = cUnitTypeypImperialArmy;
				antiCAVlow = cUnitTypeypTerritorialArmy;
				
			}
			break;
		}
		
	}
	
	mainNativeWarrior = cUnitTypeAbstractNativeWarrior; 
	mainMercenary = cUnitTypeMercenary;
	
	int heavyInfantryCountEnemy = -1;
	int lightInfantryCountEnemy = -1;
	int lightCavalryCountEnemy = -1;
	int heavyCavalryCountEnemy = -1;
	int artilleryCountEnemy = -1;
	int totalEnemyCount = -1;
	int totalEnemyInfantryCount = -1;
	int totalCavEnemy = -1;
	int totalEnemyInfantry = -1;
	int enemyToCounter = -1;
	for (x = 1; < cNumberPlayers)
	{ //loop through players
		if (kbGetPlayerTeam(cMyID) != kbGetPlayerTeam(x) && (x != cMyID) && kbHasPlayerLost(x) == false)
		{ //that are not on my team and is not me and are not dead
			enemyToCounter = x;
			heavyInfantryCountEnemy = heavyInfantryCountEnemy + kbUnitCount(enemyToCounter, cUnitTypeAbstractHeavyInfantry, cUnitStateAlive);
			lightInfantryCountEnemy = lightInfantryCountEnemy + kbUnitCount(enemyToCounter, cUnitTypeAbstractInfantry, cUnitStateAlive) - heavyInfantryCountEnemy;
			lightCavalryCountEnemy = lightCavalryCountEnemy + kbUnitCount(enemyToCounter, cUnitTypeAbstractLightCavalry, cUnitStateAlive) + kbUnitCount(enemyToCounter, cUnitTypexpEagleKnight, cUnitStateAlive); // Aztec eagle knights count as light cavalry
			heavyCavalryCountEnemy = heavyCavalryCountEnemy + kbUnitCount(enemyToCounter, cUnitTypeAbstractHeavyCavalry, cUnitStateAlive) + kbUnitCount(enemyToCounter, cUnitTypexpCoyoteMan, cUnitStateAlive); // Aztec coyote runners count as heavy cavalry
			artilleryCountEnemy = artilleryCountEnemy + kbUnitCount(enemyToCounter, cUnitTypeAbstractArtillery, cUnitStateAlive);
			totalEnemyCount = totalEnemyCount + lightInfantryCountEnemy + heavyInfantryCountEnemy + lightCavalryCountEnemy + heavyCavalryCountEnemy + artilleryCountEnemy;
			totalEnemyInfantryCount = totalEnemyInfantryCount + lightInfantryCountEnemy + heavyInfantryCountEnemy;
			totalCavEnemy = totalCavEnemy + lightCavalryCountEnemy + heavyCavalryCountEnemy;
			totalEnemyInfantry = totalEnemyInfantry + heavyInfantryCountEnemy+lightInfantryCountEnemy;
		}
	}
	int ratio = 1.0;
	int diff = 0;
	int unitCount = 0;
	float scoreLeft = 1.0;
	//cav
	int enemyCavBase = kbUnitQueryCreate("enemyCavBase");
	kbUnitQuerySetPlayerRelation(enemyCavBase, cPlayerRelationEnemyNotGaia);
	kbUnitQuerySetUnitType(enemyCavBase, cUnitTypeAbstractCavalry);
	kbUnitQuerySetPosition(enemyCavBase, kbBaseGetLocation(cMyID, kbBaseGetMainID(cMyID)) ); //set the location
	kbUnitQuerySetMaximumDistance(enemyCavBase, 30.0);
	kbUnitQuerySetIgnoreKnockedOutUnits(enemyCavBase, true);
	kbUnitQuerySetState(enemyCavBase, cUnitStateAlive);
	
	if(kbUnitQueryExecute(enemyCavBase) > 15)
	{ //defend the base with anti cav
		if(kbProtoUnitAvailable(baseCavAnti) == true  && scoreLeft > 0)
		{
			baseCavAntiValue = 1.0;
			scoreLeft = 0.0;
		}	
	}
	
	unitCount = kbUnitCount(cMyID, antiHI, cUnitStateABQ) + kbUnitCount(cMyID, antiHIlow, cUnitStateABQ);
	if(heavyInfantryCountEnemy > unitCount && kbUnitCount(cMyID, gBarracksUnit, cUnitStateAlive) != 0 )
	{ //counter HI
		
		diff = heavyInfantryCountEnemy - unitCount;
		if(diff < 15 )
		{// use low couter
			if(kbProtoUnitAvailable(antiHIlow) == true  && scoreLeft > 0.0) antiHILowValue = armyRatio(diff);
			
			
			if(antiHILowValue > scoreLeft) antiHILowValue = scoreLeft;
			scoreLeft = scoreLeft - antiHILowValue;
		}
		
		else
		{
			if(kbProtoUnitAvailable(antiHI) == true  && scoreLeft > 0) antiHIValue = armyRatio(diff);	
			if(antiHIValue > scoreLeft) antiHIValue = scoreLeft;
			scoreLeft = scoreLeft - antiHIValue;
		}	
		
	}
	
	unitCount = kbUnitCount(cMyID, antiCav, cUnitStateABQ);
	if(totalCavEnemy > unitCount && kbUnitCount(cMyID, gStableUnit, cUnitStateAlive) != 0)
	{
		diff = totalCavEnemy - unitCount;
		if(kbProtoUnitAvailable(antiCav) == true  && scoreLeft > 0) antiCavValue = armyRatio(diff);
		if(antiCavValue > scoreLeft) antiCavValue = scoreLeft;
		scoreLeft = scoreLeft - antiCavValue;
	}
	
	unitCount = kbUnitCount(cMyID, mainCavlow, cUnitStateABQ);
	if(artilleryCountEnemy > unitCount && kbUnitCount(cMyID, gStableUnit, cUnitStateAlive) != 0)
	{
		diff = artilleryCountEnemy - unitCount;
		if(kbProtoUnitAvailable(mainCavlow) == true  && scoreLeft > 0)  mainCavlowValue = armyRatio(diff);
		if(mainCavlowValue > scoreLeft) mainCavlowValue = scoreLeft;
		scoreLeft = scoreLeft - mainCavlowValue;
	}
	
	
	unitCount = kbUnitCount(cMyID, antiLI, cUnitStateABQ) + kbUnitCount(cMyID, antiLIlow, cUnitStateABQ);
	if(lightInfantryCountEnemy > unitCount && kbUnitCount(cMyID, gBarracksUnit, cUnitStateAlive) != 0)
	{
		diff = heavyInfantryCountEnemy - unitCount;
		if(diff < 15 )
		{
			if(kbProtoUnitAvailable(antiLIlow) == true  && scoreLeft > 0) antiLIlowValue = armyRatio(diff);
			if(antiLIlowValue > scoreLeft) antiLIlowValue = scoreLeft;
			scoreLeft = scoreLeft - antiLIlowValue;
		}
		else
		{
			if(kbProtoUnitAvailable(antiLI) == true  && scoreLeft > 0) antiLIValue = armyRatio(diff);	
			if(antiLIValue > scoreLeft) antiLIValue = scoreLeft;
			scoreLeft = scoreLeft - antiLIValue;
		}
		
	}
	
	unitCount = kbUnitCount(cMyID, antiCAVINF, cUnitStateABQ) + kbUnitCount(cMyID, antiCAVlow, cUnitStateABQ);
	if(heavyCavalryCountEnemy > unitCount && kbUnitCount(cMyID, gStableUnit, cUnitStateAlive) != 0)
	{
		diff = heavyCavalryCountEnemy - unitCount;
		if(diff < 15 )
		{
			if(kbProtoUnitAvailable(antiCAVlow) == true  && scoreLeft > 0) antiCAVlowValue = armyRatio(diff);
			if(antiCAVlowValue > scoreLeft) antiCAVlowValue = scoreLeft;
			scoreLeft = scoreLeft - antiCAVlowValue;
		}
		else
		{
			if(kbProtoUnitAvailable(antiCAVINF) == true  && scoreLeft > 0) antiCAVINFValue = armyRatio(diff);
			if(antiCAVINFValue > scoreLeft) antiCAVINFValue = scoreLeft;
			scoreLeft = scoreLeft - antiCAVINFValue;
		}
	}
	
	unitCount = kbUnitCount(cMyID, antiLC, cUnitStateABQ) + kbUnitCount(cMyID, antiLClow, cUnitStateABQ);
	if(lightCavalryCountEnemy > unitCount && kbUnitCount(cMyID, gStableUnit, cUnitStateAlive) != 0)
	{
		diff = heavyCavalryCountEnemy - unitCount;
		if(diff < 15 )
		{
			if(kbProtoUnitAvailable(antiLClow) == true  && scoreLeft > 0) antiLClowValue = armyRatio(diff);
			if(antiLClowValue > scoreLeft) antiLClowValue = scoreLeft;
			scoreLeft = scoreLeft - antiLClowValue;
		}
		else
		{
			if(kbProtoUnitAvailable(antiLC) == true  && scoreLeft > 0) antiLCValue = armyRatio(diff);
			if(antiLCValue > scoreLeft) antiLCValue = scoreLeft;
			scoreLeft = scoreLeft - antiLCValue; 
		}
	}
	
	unitCount = kbUnitCount(cMyID, mainArt, cUnitStateABQ);
	unitCount = unitCount * 3;
	if(totalEnemyInfantry > unitCount && kbUnitCount(cMyID, gArtilleryDepotUnit, cUnitStateAlive) != 0)
	{
		diff = totalEnemyInfantry - unitCount;
		//diff = diff / 2;
		if(kbProtoUnitAvailable(mainArt) == true  && scoreLeft > 0)
		{
			mainArtValue = armyRatio(diff);	
			if(mainArtValue > scoreLeft) mainArtValue = scoreLeft;
			scoreLeft = scoreLeft - mainArtValue;
			
		}
		else
		{
			if(kbProtoUnitAvailable(mainArtlowValue) == true  && scoreLeft > 0) mainArtlowValue = armyRatio(diff);
			if(mainArtlowValue > scoreLeft) mainArtlowValue = scoreLeft;
			scoreLeft = scoreLeft - mainArtlowValue;
			
		}
	}
	
	unitCount = kbUnitCount(cMyID, mainArtAnti, cUnitStateABQ);
	if(artilleryCountEnemy > unitCount && kbUnitCount(cMyID, gArtilleryDepotUnit, cUnitStateAlive) != 0)
	{
		diff = artilleryCountEnemy - unitCount;
		if(kbProtoUnitAvailable(mainArtAnti) == true  && scoreLeft > 0) mainArtAntiValue = armyRatio(diff);
		//if(mainArtAntiValue > 0.3) mainArtAntiValue = 0.3;
		if(mainArtAntiValue > scoreLeft) mainArtAntiValue = scoreLeft;
		scoreLeft = scoreLeft - mainArtAntiValue;
	}
	
	if(kbGetPop() > 200 && kbUnitCount(cMyID, cUnitTypeChurch, cUnitStateAlive) != 0) 
	{
		mainMercenaryValue = scoreLeft;
		scoreLeft = 0.0;
		
	}
	
	//inf
	unitCount = kbUnitCount(cMyID, mainINF, cUnitStateABQ);
	if(totalEnemyInfantryCount > unitCount && kbUnitCount(cMyID, gBarracksUnit, cUnitStateAlive) != 0)
	{
		diff = totalEnemyInfantryCount - unitCount;
		
		if(diff < 15 )
		{
			if(kbProtoUnitAvailable(mainINFlow) == true  && scoreLeft > 0) mainINFlowValue = armyRatio(diff);
			scoreLeft = scoreLeft - mainINFlowValue;	
		}
		
		else if(kbProtoUnitAvailable(mainINF) == true  && scoreLeft > 0)
		{
			if(kbProtoUnitAvailable(mainINF) == true  && scoreLeft > 0)  mainINFValue = armyRatio(diff);
			scoreLeft = scoreLeft - mainINFValue;
			
		}
	}
	
	if(kbProtoUnitAvailable(mainCav) == true  && scoreLeft > 0 && kbUnitCount(cMyID, gStableUnit, cUnitStateAlive) != 0)
	{
		mainCavValue = scoreLeft;
		scoreLeft = 0.0;
	}
	
	else
	{
		if(kbProtoUnitAvailable(mainCavlow) == true  && scoreLeft > 0 && kbUnitCount(cMyID, gStableUnit, cUnitStateAlive) != 0) 
		{
			mainCavlowValue = scoreLeft;
			scoreLeft = 0.0;
		}
	}
	
	if(kbGetPop() == (kbGetPopCap()))
	{
		mainCavValue = 0.0;
		mainCavlowValue = 0.0;
		antiCavValue = 0.0;
		mainArtValue = 0.0;
		mainArtlowValue = 0.0;
		mainArtAntiValue = 0.0;
		mainINFValue = 0.0;
		mainINFlowValue = 0.0;
		antiHIValue = 0.0;
		antiHILowValue = 0.0;
		antiLIValue = 0.0;
		antiLIlowValue = 0.0;
		antiLCValue = 0.0;
		antiLClowValue = 0.0;
		antiCAVINFValue = 0.0;
		antiCAVlowValue = 0.0;
		baseCavAntiValue = 0.0;
		mainNativeWarriorValue = 0.5;
		mainMercenaryValue = 0.5;
	}
	
	if(kbResourceGet(cResourceFood) < 200 && kbGetCiv() != cCivDutch)
	{
		mainCavValue = 0.0;
		mainCavlowValue = 0.0;
		antiCavValue = 0.0;
		mainArtValue = 0.0;
		mainArtlowValue = 0.0;
		mainArtAntiValue = 0.0;
		mainINFValue = 0.0;
		mainINFlowValue = 0.0;
		antiHIValue = 0.0;
		antiHILowValue = 0.0;
		antiLIValue = 0.0;
		antiLIlowValue = 0.0;
		antiLCValue = 0.0;
		antiLClowValue = 0.0;
		antiCAVINFValue = 0.0;
		antiCAVlowValue = 0.0;
		baseCavAntiValue = 0.0;
		mainNativeWarriorValue = 0.0;
		mainMercenaryValue = 0.0;
	}
	
	if(kbResourceGet(cResourceGold) < 200 && kbGetCiv() == cCivDutch)
	{
		mainCavValue = 0.0;
		mainCavlowValue = 0.0;
		antiCavValue = 0.0;
		mainArtValue = 0.0;
		mainArtlowValue = 0.0;
		mainArtAntiValue = 0.0;
		mainINFValue = 0.0;
		mainINFlowValue = 0.0;
		antiHIValue = 0.0;
		antiHILowValue = 0.0;
		antiLIValue = 0.0;
		antiLIlowValue = 0.0;
		antiLCValue = 0.0;
		antiLClowValue = 0.0;
		antiCAVINFValue = 0.0;
		antiCAVlowValue = 0.0;
		baseCavAntiValue = 0.0;
		mainNativeWarriorValue = 0.0;
		mainMercenaryValue = 0.0;
	}
	
	
	if(kbGetAge() < cAge3)
	{
		antiCavPlan = createSimpleMaintainPlan(antiCav, (gMaxPopFixValue * antiCavValue), true, kbBaseGetMainID(cMyID), 5);
		
		//kbUnitPickSetPreferenceFactor(gLandUnitPicker, antiCav, antiCavValue);
		scoreLeft = scoreLeft - antiCavValue;
		//kbUnitPickSetPreferenceFactor(gLandUnitPicker, mainCav, scoreLeft);
		mainCavPlan = createSimpleMaintainPlan(mainCav, (gMaxPopFixValue * scoreLeft), true, kbBaseGetMainID(cMyID), 5);
		addItemToForecasts(mainCav, (gMaxPopFixValue * scoreLeft)); 
		
	}
	
	else
	{
		
		
		mainNativeWarriorPlan = createSimpleMaintainPlan(mainNativeWarrior, (gMaxPopFixValue * mainNativeWarriorValue), true, kbBaseGetMainID(cMyID), 5);
		mainMercenaryPlan = createSimpleMaintainPlan(mainMercenary, (gMaxPopFixValue * mainMercenaryValue), true, kbBaseGetMainID(cMyID), 5);
		baseCavAntiPlan = createSimpleMaintainPlan(baseCavAnti, (gMaxPopFixValue * baseCavAntiValue), true, kbBaseGetMainID(cMyID), 5);	
		antiHILowPlan = createSimpleMaintainPlan(antiHIlow, (gMaxPopFixValue * antiHILowValue), true, kbBaseGetMainID(cMyID), 5);
		antiHIPlan = createSimpleMaintainPlan(antiHI, (gMaxPopFixValue * antiHIValue), true, kbBaseGetMainID(cMyID), 5);
		antiLIlowPlan = createSimpleMaintainPlan(antiLIlow, (gMaxPopFixValue * antiLIlowValue), true, kbBaseGetMainID(cMyID), 5);
		antiLIPlan = createSimpleMaintainPlan(antiLI, (gMaxPopFixValue * antiLIValue), true, kbBaseGetMainID(cMyID), 5);
		antiLCPlan = createSimpleMaintainPlan(antiLC, (gMaxPopFixValue * antiLCValue), true, kbBaseGetMainID(cMyID), 5);
		antiLClowPlan = createSimpleMaintainPlan(antiLClow, (gMaxPopFixValue * antiLClowValue), true, kbBaseGetMainID(cMyID), 5);
		antiCavPlan = createSimpleMaintainPlan(antiCav, (gMaxPopFixValue * antiCavValue), true, kbBaseGetMainID(cMyID), 5);
		mainCavlowPlan = createSimpleMaintainPlan(antiCAVlow, (gMaxPopFixValue * antiCAVlowValue), true, kbBaseGetMainID(cMyID), 5);
		antiCAVINFPlan = createSimpleMaintainPlan(antiCAVINF, (gMaxPopFixValue * antiCAVINFValue), true, kbBaseGetMainID(cMyID), 5);
		mainArtAntiPlan = createSimpleMaintainPlan(mainArtAnti, (gMaxPopFixValue * mainArtAntiValue), true, kbBaseGetMainID(cMyID), 5);
		mainArtlowPlan = createSimpleMaintainPlan(mainArtlow, (gMaxPopFixValue * mainArtlowValue), true, kbBaseGetMainID(cMyID), 5);
		mainArtPlan = createSimpleMaintainPlan(mainArt, (gMaxPopFixValue * mainArtValue), true, kbBaseGetMainID(cMyID), 5);
		mainINFlowPlan = createSimpleMaintainPlan(mainINFlow, (gMaxPopFixValue * mainINFlowValue), true, kbBaseGetMainID(cMyID), 5);
		antiCAVlowPlan = createSimpleMaintainPlan(mainCavlow, (gMaxPopFixValue * mainCavlowValue), true, kbBaseGetMainID(cMyID), 5);
		mainINFPlan = createSimpleMaintainPlan(mainINF, (gMaxPopFixValue * mainINFValue), true, kbBaseGetMainID(cMyID), 5);
		mainCavPlan = createSimpleMaintainPlan(mainCav, (gMaxPopFixValue * mainCavValue), true, kbBaseGetMainID(cMyID), 5);
		
		
		addItemToForecasts(mainNativeWarrior, (gMaxPopFixValue * mainNativeWarriorValue));
		addItemToForecasts(mainMercenary, (gMaxPopFixValue * mainMercenary));
		addItemToForecasts(baseCavAnti, (gMaxPopFixValue * baseCavAnti));
		addItemToForecasts(antiHIlow, (gMaxPopFixValue * antiHIlow));
		addItemToForecasts(antiHI, (gMaxPopFixValue * antiHI));
		addItemToForecasts(antiLIlow, (gMaxPopFixValue * antiLIlow));
		addItemToForecasts(antiLI, (gMaxPopFixValue * antiLI));
		addItemToForecasts(antiLC, (gMaxPopFixValue * antiLC));
		addItemToForecasts(antiLClow, (gMaxPopFixValue * antiLClow));
		addItemToForecasts(antiCav, (gMaxPopFixValue * antiCav));
		addItemToForecasts(antiCAVlow, (gMaxPopFixValue * antiCAVlow));
		addItemToForecasts(antiCAVINF, (gMaxPopFixValue * antiCAVINF));
		addItemToForecasts(mainArtAnti, (gMaxPopFixValue * mainArtAnti));
		addItemToForecasts(mainArtlow, (gMaxPopFixValue * mainArtlow));
		addItemToForecasts(mainArt, (gMaxPopFixValue * mainArt));
		addItemToForecasts(mainINFlow, (gMaxPopFixValue * mainINFlow));
		addItemToForecasts(mainCavlow, (gMaxPopFixValue * mainCavlow));
		addItemToForecasts(mainINF, (gMaxPopFixValue * mainINF));
		addItemToForecasts(mainCav, (gMaxPopFixValue * mainCav)); 
		
	}
	
	if(kbUnitCount(cMyID, mainCav, cUnitStateAlive) < 5)
	{
		aiTaskUnitTrain(getUnit(gStableUnit), kbUnitGetProtoUnitID(mainCav));
		aiTaskUnitTrain(getUnit(gStableUnit), kbUnitGetProtoUnitID(mainCav));
		aiTaskUnitTrain(getUnit(gStableUnit), kbUnitGetProtoUnitID(mainCav));
		aiTaskUnitTrain(getUnit(gStableUnit), kbUnitGetProtoUnitID(mainCav));
		aiTaskUnitTrain(getUnit(gStableUnit), kbUnitGetProtoUnitID(mainCav));
		addItemToForecasts(mainCav, 5); 
	}
	
	
	
}


rule militaryManager
active
minInterval 30 //30
{
	
	static bool init = false;   // Flag to indicate vars, plans are initialized
	int i = 0;
	int proto = 0;
	int planID = -1;
	
	//if (aiGetWorldDifficulty() == cDifficultyExpert) kbLookAtAllUnitsOnMap();
	
	if(kbGetCiv() == cCivFrench || 
		kbGetCiv() == cCivJapanese || 
		kbGetCiv() == cCivSpanish || 
		kbGetCiv() == cCivBritish || 
		kbGetCiv() == cCivPortuguese || 
		kbGetCiv() == cCivDutch || 
		kbGetCiv() == cCivRussians || 
		kbGetCiv() == cCivGermans || 
		kbGetCiv() == cCivOttomans || 
		kbGetCiv() == cCivXPIroquois || 
		kbGetCiv() == cCivXPSioux || 
		kbGetCiv() == cCivXPAztec || 
		kbGetCiv() == cCivUSA || 
		kbGetCiv() == cCivSwedish || 
		kbGetCiv() == cCivChinese || 
		kbGetCiv() == cCivIndians || 
	kbGetCiv() == cCivItalians)
	{		
		armyTrain();
	}
	else
	{
		if (init == true)
		{     
			// Need to initialize, if we're allowed to.
			if (cvOkToTrainArmy == true)
			{
				init = false;
				//if (cvNumArmyUnitTypes >= 0)
				//gNumArmyUnitTypes = cvNumArmyUnitTypes;
				//else
				gNumArmyUnitTypes = 19;
				gLandUnitPicker = initUnitPicker("Land military units", gNumArmyUnitTypes, 1, 60, -1, -1, 1, true); 
				
				// now the goal
				// wmj -- hard coded for now, but this should most likely ramp up as the ages progress
				//aiSetMinArmySize(15);
				aiPlanDestroy(gMainAttackGoal);
				gMainAttackGoal = createSimpleAttackGoal("AttackGoal", aiGetMostHatedPlayerID(), gLandUnitPicker, -1, cAge2, -1, gMainBase, false);
				aiPlanSetVariableInt(gMainAttackGoal, cGoalPlanReservePlanID, 0, gLandReservePlan);
			}
		}
	}
	
	
	
	/*
		//static bool init = false;   // Flag to indicate vars, plans are initialized
		int i = 0;
		int proto = 0;
		int planID = -1;
		
		// if (init == false)
		//{  
		if (newAttackGoal == -1)
		{     
		//newAttackGoal = 0;
		aiPlanDestroyByName("AttackGoal");
		// Need to initialize, if we're allowed to.
		if (cvOkToTrainArmy == true)
		{
		
		
		//				init = true;
		if (cvNumArmyUnitTypes >= 0)
		gNumArmyUnitTypes = cvNumArmyUnitTypes;
		else
		gNumArmyUnitTypes = 19;
		
		gLandUnitPicker = initUnitPicker("Land military units", gNumArmyUnitTypes, 1, 60, -1, -1, 1, true); 
		
		
		// now the goal
		// wmj -- hard coded for now, but this should most likely ramp up as the ages progress
		//aiSetMinArmySize(15);
		
		gMainAttackGoal = createSimpleAttackGoal("AttackGoal", aiGetMostHatedPlayerID(), gLandUnitPicker, -1, cAge2, -1, gMainBase, false);
		aiPlanSetVariableInt(gMainAttackGoal, cGoalPlanReservePlanID, 0, gLandReservePlan);
		}
		}
		//}
	*/
	//updatedOn 2019/05/10 By ageekhere  
	//---------------------------
	if(gLandUnitPicker != -1)
	{
		setUnitPickerPreference(gLandUnitPicker); // Update preferences in case btBiasEtc vars have changed, or cvPrimaryArmyUnit has changed.
		//if(capedPop != -1)
		//{
			//	kbUnitPickSetMinimumNumberUnits(gLandUnitPicker, 5);
			//	kbUnitPickSetMaximumNumberUnits(gLandUnitPicker, gMaxPopFixValue);
		//}
		if(revolted == true)
		{
			kbUnitPickSetMinimumNumberUnits(gLandUnitPicker, 5);
			kbUnitPickSetMaximumNumberUnits(gLandUnitPicker, gMaxPopFixValue);
		}
		
		else if(kbGetAge() == cAge2)
		{
			kbUnitPickSetMinimumNumberUnits(gLandUnitPicker, 10);     
			kbUnitPickSetMaximumNumberUnits(gLandUnitPicker, gMaxPopFixValue);
		}
		
		else if(kbGetAge() == cAge3)
		{
			kbUnitPickSetMinimumNumberUnits(gLandUnitPicker, 60);                                                           
			kbUnitPickSetMaximumNumberUnits(gLandUnitPicker, gMaxPopFixValue);
		}
		else if(kbGetAge() == cAge4)
		{
			kbUnitPickSetMinimumNumberUnits(gLandUnitPicker, 80);
			kbUnitPickSetMaximumNumberUnits(gLandUnitPicker, gMaxPopFixValue);
		}
		else if(kbGetAge() == cAge5)
		{
			kbUnitPickSetMinimumNumberUnits(gLandUnitPicker, 100);
			kbUnitPickSetMaximumNumberUnits(gLandUnitPicker, gMaxPopFixValue);
			//kbUnitPickSetMaximumNumberUnits(gLandUnitPicker, 90);
		}
	}
	//---------------------------
	
	switch(kbGetAge())
	{
		case cAge1:
		{
			break;
		}
		case cAge2:
		{
			aiSetMinArmySize(20); // Now irrelevant?  (Was used to determine when to launch attack, but attack goal and opp scoring now do this.)
			break;
		}
		case cAge3:
		{
			aiSetMinArmySize(60);
			break;
		}
		case cAge4:
		{
			aiSetMinArmySize(80);//25
			break;
		}
		case cAge5:
		{
			aiSetMinArmySize(100);//30
			break;
		}
	}
}
