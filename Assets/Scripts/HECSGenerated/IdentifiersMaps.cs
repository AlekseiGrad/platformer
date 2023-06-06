using System.Collections.Generic;public static class AnimationEventIdentifierMap{	public static int AttackAnimationEventIdentifier => 1621750870;	public static int EnemyAttackAnimationEventIdentifier => -1133247815;	public static int EnemyEndAttackAnimationEventIdentifier => 24720778;}public static class InputIdentifierMap{	public static int Attack => 518778124;	public static int Jump => 153253362;	public static int Move => 148469141;}public static class SpawnerIdentifiersMap{	public static int Character => 1733523006;	public static int Enemy => 298054430;}public static class UIIdentifierMap{	public static int Dialogue => 1207679710;}public static partial class EntityContainersMap{	static EntityContainersMap()	{		EntityContainersIDtoString = new Dictionary<int, string>		{			{ 1276818466, "CharacterCameraContainerCLONE" },			{ 1429482425, "DefaultCharacterContainer" },			{ 2069223362, "EnemyContainer" },			{ 1747317711, "EnemySpawnPointContainer" },			{ 1594580010, "GameLogic" },			{ -183182050, "InputManagerContainer" },			{ -2023033285, "MovingPlatformContainer" },			{ -1294508521, "SpawnPointContainer" },		};	}	public static int CharacterCameraContainerCLONE => 1276818466;	public static string CharacterCameraContainerCLONE_string => "CharacterCameraContainerCLONE";	public static int DefaultCharacterContainer => 1429482425;	public static string DefaultCharacterContainer_string => "DefaultCharacterContainer";	public static int EnemyContainer => 2069223362;	public static string EnemyContainer_string => "EnemyContainer";	public static int EnemySpawnPointContainer => 1747317711;	public static string EnemySpawnPointContainer_string => "EnemySpawnPointContainer";	public static int GameLogic => 1594580010;	public static string GameLogic_string => "GameLogic";	public static int InputManagerContainer => -183182050;	public static string InputManagerContainer_string => "InputManagerContainer";	public static int MovingPlatformContainer => -2023033285;	public static string MovingPlatformContainer_string => "MovingPlatformContainer";	public static int SpawnPointContainer => -1294508521;	public static string SpawnPointContainer_string => "SpawnPointContainer";}public static partial class AbilitiesMap{	static AbilitiesMap()	{		AbilitiesToIdentifiersMap = new Dictionary<string, int>		{		};	}}public static class NetworkEntityContainersMap{}public static class IdentifierToStringMap{	public static readonly Dictionary<int, string> IntToString = new Dictionary<int, string>	{		{ 1621750870, "AttackAnimationEventIdentifier"},		{ -1133247815, "EnemyAttackAnimationEventIdentifier"},		{ 24720778, "EnemyEndAttackAnimationEventIdentifier"},		{ 518778124, "Attack"},		{ 153253362, "Jump"},		{ 148469141, "Move"},		{ 1733523006, "Character"},		{ 298054430, "Enemy"},		{ 1207679710, "Dialogue"},	};	public const string AttackAnimationEventIdentifier = "AttackAnimationEventIdentifier";	public const string EnemyAttackAnimationEventIdentifier = "EnemyAttackAnimationEventIdentifier";	public const string EnemyEndAttackAnimationEventIdentifier = "EnemyEndAttackAnimationEventIdentifier";	public const string Attack = "Attack";	public const string Jump = "Jump";	public const string Move = "Move";	public const string Character = "Character";	public const string Enemy = "Enemy";	public const string Dialogue = "Dialogue";}