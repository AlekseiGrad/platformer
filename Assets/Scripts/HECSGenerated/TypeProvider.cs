using System.Collections.Generic;using Components;using System;using Systems;namespace HECSFramework.Core{	public partial class TypesProvider	{		public TypesProvider()		{			Count = 76;			MapIndexes = GetMapIndexes();			TypeToComponentIndex = GetTypeToComponentIndexes();			HashToType = GetHashToTypeDictionary();			TypeToHash = GetTypeToHash();			HECSFactory = new HECSFactory();		}		private Dictionary<Type, int> GetTypeToComponentIndexes()		{			return new Dictionary<Type, int>()			{				{ typeof(AnimationComponent), 1 },				{ typeof(AttackComponent), 2 },				{ typeof(CameraComponent), 3 },				{ typeof(CameraProviderComponent), 4 },				{ typeof(CharacterComponent), 5 },				{ typeof(CharacterTagComponent), 6 },				{ typeof(DamageComponent), 7 },				{ typeof(DefaultCharacterHolderComponent), 8 },				{ typeof(EnemyComponent), 9 },				{ typeof(EnemyTagComponent), 10 },				{ typeof(GroundCheckComponent), 11 },				{ typeof(HealthComponent), 12 },				{ typeof(MovementComponent), 13 },				{ typeof(MoveVectorComponent), 14 },				{ typeof(MovingPlatformComponent), 15 },				{ typeof(Rigidbody2DProviderComponent), 16 },				{ typeof(SpawnPointTagComponent), 17 },				{ typeof(SpriteRendererProviderComponent), 18 },				{ typeof(VelocityComponent), 19 },				{ typeof(SavePositionComponent), 20 },				{ typeof(ViewReferenceComponent), 21 },				{ typeof(ActionsHolderComponent), 22 },				{ typeof(AbilityOwnerComponent), 23 },				{ typeof(AbilityPredicateComponent), 24 },				{ typeof(ActorContainerID), 25 },				{ typeof(ActorProviderComponent), 26 },				{ typeof(AppVersionComponent), 27 },				{ typeof(PoolableTagComponent), 28 },				{ typeof(PredicatesComponent), 29 },				{ typeof(AnimatorStateComponent), 30 },				{ typeof(CountersHolderComponent), 31 },				{ typeof(TestSerializationComponent), 32 },				{ typeof(TransformComponent), 33 },				{ typeof(AIStrategyComponent), 34 },				{ typeof(WaitStateComponent), 35 },				{ typeof(CacheCounterValuesComponent), 36 },				{ typeof(UntilSuccessStrategyNodeComponent), 37 },				{ typeof(AbilitiesHolderComponent), 38 },				{ typeof(AdditionalAbilityIndexComponent), 39 },				{ typeof(AfterLifeCompleteTagComponent), 40 },				{ typeof(AfterLifeTagComponent), 41 },				{ typeof(GameLogicTagComponent), 42 },				{ typeof(InputActionsComponent), 43 },				{ typeof(InputListenerTagComponent), 44 },				{ typeof(ItemTagComponent), 45 },				{ typeof(NavMeshAgentComponent), 46 },				{ typeof(NetworkEntityTagComponent), 47 },				{ typeof(PoolableViewsProviderComponent), 48 },				{ typeof(TimeProviderComponent), 49 },				{ typeof(UIGroupTagComponent), 50 },				{ typeof(UIViewReferenceComponent), 51 },				{ typeof(UnityRectTransformComponent), 52 },				{ typeof(UnityTransformComponent), 53 },				{ typeof(ViewDestructionDelayedComponent), 54 },				{ typeof(ViewReferenceGameObjectComponent), 55 },				{ typeof(SoundVolumeComponent), 56 },				{ typeof(CheckTwoComponent), 57 },				{ typeof(TestReactComponent), 58 },				{ typeof(AbilityTagComponent), 59 },				{ typeof(PassiveAbilityTag), 60 },				{ typeof(ScenarioAnimationComponent), 61 },				{ typeof(StateContextComponent), 62 },				{ typeof(StateDataComponent), 63 },				{ typeof(StateInfoComponent), 64 },				{ typeof(AnimationCheckOutsHolderComponent), 65 },				{ typeof(OverrideAnimatorComponent), 66 },				{ typeof(SetupAfterViewTagComponent), 67 },				{ typeof(ViewReadyTagComponent), 68 },				{ typeof(RadiusComponent), 69 },				{ typeof(StickTagComponent), 70 },				{ typeof(AdditionalCanvasTagComponent), 71 },				{ typeof(MainCanvasTagComponent), 72 },				{ typeof(UITagComponent), 73 },				{ typeof(TestComponent), 74 },				{ typeof(TestWorldSingleComponent), 75 },			};		}		private Dictionary<Type, int> GetTypeToHash()		{			return new Dictionary<Type, int>()			{				{ typeof(AnimationComponent), 891356082 },				{ typeof(AttackComponent), -596259457 },				{ typeof(CameraComponent), -611987101 },				{ typeof(CameraProviderComponent), -1555258315 },				{ typeof(CharacterComponent), 889396852 },				{ typeof(CharacterTagComponent), 37992040 },				{ typeof(DamageComponent), -623718192 },				{ typeof(DefaultCharacterHolderComponent), -17579568 },				{ typeof(EnemyComponent), -2131779644 },				{ typeof(EnemyTagComponent), -1416715012 },				{ typeof(GroundCheckComponent), 1389512473 },				{ typeof(HealthComponent), -589508998 },				{ typeof(MovementComponent), -1302026474 },				{ typeof(MoveVectorComponent), -1036563749 },				{ typeof(MovingPlatformComponent), -1531631635 },				{ typeof(Rigidbody2DProviderComponent), -931447152 },				{ typeof(SpawnPointTagComponent), -1143404840 },				{ typeof(SpriteRendererProviderComponent), 597019103 },				{ typeof(VelocityComponent), -1227376375 },				{ typeof(SavePositionComponent), 369067176 },				{ typeof(ViewReferenceComponent), -1029564515 },				{ typeof(ActionsHolderComponent), -942979946 },				{ typeof(AbilityOwnerComponent), 313621202 },				{ typeof(AbilityPredicateComponent), 1878456296 },				{ typeof(ActorContainerID), -142928435 },				{ typeof(ActorProviderComponent), -803245354 },				{ typeof(AppVersionComponent), -988064901 },				{ typeof(PoolableTagComponent), 1354058828 },				{ typeof(PredicatesComponent), -1064941338 },				{ typeof(AnimatorStateComponent), -950198728 },				{ typeof(CountersHolderComponent), -1627736277 },				{ typeof(TestSerializationComponent), -1713719609 },				{ typeof(TransformComponent), 888932549 },				{ typeof(AIStrategyComponent), -952149029 },				{ typeof(WaitStateComponent), 867896372 },				{ typeof(CacheCounterValuesComponent), -1378915465 },				{ typeof(UntilSuccessStrategyNodeComponent), 1143262242 },				{ typeof(AbilitiesHolderComponent), 2041590961 },				{ typeof(AdditionalAbilityIndexComponent), 274782965 },				{ typeof(AfterLifeCompleteTagComponent), 53484848 },				{ typeof(AfterLifeTagComponent), -88497250 },				{ typeof(GameLogicTagComponent), -100950956 },				{ typeof(InputActionsComponent), 369850288 },				{ typeof(InputListenerTagComponent), 1776997060 },				{ typeof(ItemTagComponent), 1004631539 },				{ typeof(NavMeshAgentComponent), 117603503 },				{ typeof(NetworkEntityTagComponent), 1908646573 },				{ typeof(PoolableViewsProviderComponent), -1535532641 },				{ typeof(TimeProviderComponent), 265593849 },				{ typeof(UIGroupTagComponent), -1162002111 },				{ typeof(UIViewReferenceComponent), 1908410989 },				{ typeof(UnityRectTransformComponent), -1206519595 },				{ typeof(UnityTransformComponent), -1425063609 },				{ typeof(ViewDestructionDelayedComponent), 42315994 },				{ typeof(ViewReferenceGameObjectComponent), 1656499746 },				{ typeof(SoundVolumeComponent), 1587816967 },				{ typeof(CheckTwoComponent), -1325613894 },				{ typeof(TestReactComponent), 815927063 },				{ typeof(AbilityTagComponent), -1150856501 },				{ typeof(PassiveAbilityTag), -1856633313 },				{ typeof(ScenarioAnimationComponent), -1965185654 },				{ typeof(StateContextComponent), 387690372 },				{ typeof(StateDataComponent), 760681168 },				{ typeof(StateInfoComponent), 819793506 },				{ typeof(AnimationCheckOutsHolderComponent), 1046176786 },				{ typeof(OverrideAnimatorComponent), -2117687604 },				{ typeof(SetupAfterViewTagComponent), 1782176358 },				{ typeof(ViewReadyTagComponent), 7120005 },				{ typeof(RadiusComponent), -575221824 },				{ typeof(StickTagComponent), -1422875746 },				{ typeof(AdditionalCanvasTagComponent), -1191206187 },				{ typeof(MainCanvasTagComponent), -1144719428 },				{ typeof(UITagComponent), -2124047058 },				{ typeof(TestComponent), 956328563 },				{ typeof(TestWorldSingleComponent), 2004170910 },			};		}		private Dictionary<int, Type> GetHashToTypeDictionary()		{			return new Dictionary<int, Type>()			{				{ 891356082, typeof(AnimationComponent)},				{ -596259457, typeof(AttackComponent)},				{ -611987101, typeof(CameraComponent)},				{ -1555258315, typeof(CameraProviderComponent)},				{ 889396852, typeof(CharacterComponent)},				{ 37992040, typeof(CharacterTagComponent)},				{ -623718192, typeof(DamageComponent)},				{ -17579568, typeof(DefaultCharacterHolderComponent)},				{ -2131779644, typeof(EnemyComponent)},				{ -1416715012, typeof(EnemyTagComponent)},				{ 1389512473, typeof(GroundCheckComponent)},				{ -589508998, typeof(HealthComponent)},				{ -1302026474, typeof(MovementComponent)},				{ -1036563749, typeof(MoveVectorComponent)},				{ -1531631635, typeof(MovingPlatformComponent)},				{ -931447152, typeof(Rigidbody2DProviderComponent)},				{ -1143404840, typeof(SpawnPointTagComponent)},				{ 597019103, typeof(SpriteRendererProviderComponent)},				{ -1227376375, typeof(VelocityComponent)},				{ 369067176, typeof(SavePositionComponent)},				{ -1029564515, typeof(ViewReferenceComponent)},				{ -942979946, typeof(ActionsHolderComponent)},				{ 313621202, typeof(AbilityOwnerComponent)},				{ 1878456296, typeof(AbilityPredicateComponent)},				{ -142928435, typeof(ActorContainerID)},				{ -803245354, typeof(ActorProviderComponent)},				{ -988064901, typeof(AppVersionComponent)},				{ 1354058828, typeof(PoolableTagComponent)},				{ -1064941338, typeof(PredicatesComponent)},				{ -950198728, typeof(AnimatorStateComponent)},				{ -1627736277, typeof(CountersHolderComponent)},				{ -1713719609, typeof(TestSerializationComponent)},				{ 888932549, typeof(TransformComponent)},				{ -952149029, typeof(AIStrategyComponent)},				{ 867896372, typeof(WaitStateComponent)},				{ -1378915465, typeof(CacheCounterValuesComponent)},				{ 1143262242, typeof(UntilSuccessStrategyNodeComponent)},				{ 2041590961, typeof(AbilitiesHolderComponent)},				{ 274782965, typeof(AdditionalAbilityIndexComponent)},				{ 53484848, typeof(AfterLifeCompleteTagComponent)},				{ -88497250, typeof(AfterLifeTagComponent)},				{ -100950956, typeof(GameLogicTagComponent)},				{ 369850288, typeof(InputActionsComponent)},				{ 1776997060, typeof(InputListenerTagComponent)},				{ 1004631539, typeof(ItemTagComponent)},				{ 117603503, typeof(NavMeshAgentComponent)},				{ 1908646573, typeof(NetworkEntityTagComponent)},				{ -1535532641, typeof(PoolableViewsProviderComponent)},				{ 265593849, typeof(TimeProviderComponent)},				{ -1162002111, typeof(UIGroupTagComponent)},				{ 1908410989, typeof(UIViewReferenceComponent)},				{ -1206519595, typeof(UnityRectTransformComponent)},				{ -1425063609, typeof(UnityTransformComponent)},				{ 42315994, typeof(ViewDestructionDelayedComponent)},				{ 1656499746, typeof(ViewReferenceGameObjectComponent)},				{ 1587816967, typeof(SoundVolumeComponent)},				{ -1325613894, typeof(CheckTwoComponent)},				{ 815927063, typeof(TestReactComponent)},				{ -1150856501, typeof(AbilityTagComponent)},				{ -1856633313, typeof(PassiveAbilityTag)},				{ -1965185654, typeof(ScenarioAnimationComponent)},				{ 387690372, typeof(StateContextComponent)},				{ 760681168, typeof(StateDataComponent)},				{ 819793506, typeof(StateInfoComponent)},				{ 1046176786, typeof(AnimationCheckOutsHolderComponent)},				{ -2117687604, typeof(OverrideAnimatorComponent)},				{ 1782176358, typeof(SetupAfterViewTagComponent)},				{ 7120005, typeof(ViewReadyTagComponent)},				{ -575221824, typeof(RadiusComponent)},				{ -1422875746, typeof(StickTagComponent)},				{ -1191206187, typeof(AdditionalCanvasTagComponent)},				{ -1144719428, typeof(MainCanvasTagComponent)},				{ -2124047058, typeof(UITagComponent)},				{ 956328563, typeof(TestComponent)},				{ 2004170910, typeof(TestWorldSingleComponent)},			};		}		private Dictionary<int, ComponentMaskAndIndex> GetMapIndexes()		{			return new Dictionary<int, ComponentMaskAndIndex>			{				{ -1, new ComponentMaskAndIndex {  ComponentName = "DefaultEmpty", ComponentsMask = HECSMask.Empty }},			{ 891356082, new ComponentMaskAndIndex {ComponentName = "AnimationComponent", ComponentsMask = new HECSMask				{					Index = 1,					TypeHashCode = 891356082,				}			}},			{ -596259457, new ComponentMaskAndIndex {ComponentName = "AttackComponent", ComponentsMask = new HECSMask				{					Index = 2,					TypeHashCode = -596259457,				}			}},			{ -611987101, new ComponentMaskAndIndex {ComponentName = "CameraComponent", ComponentsMask = new HECSMask				{					Index = 3,					TypeHashCode = -611987101,				}			}},			{ -1555258315, new ComponentMaskAndIndex {ComponentName = "CameraProviderComponent", ComponentsMask = new HECSMask				{					Index = 4,					TypeHashCode = -1555258315,				}			}},			{ 889396852, new ComponentMaskAndIndex {ComponentName = "CharacterComponent", ComponentsMask = new HECSMask				{					Index = 5,					TypeHashCode = 889396852,				}			}},			{ 37992040, new ComponentMaskAndIndex {ComponentName = "CharacterTagComponent", ComponentsMask = new HECSMask				{					Index = 6,					TypeHashCode = 37992040,				}			}},			{ -623718192, new ComponentMaskAndIndex {ComponentName = "DamageComponent", ComponentsMask = new HECSMask				{					Index = 7,					TypeHashCode = -623718192,				}			}},			{ -17579568, new ComponentMaskAndIndex {ComponentName = "DefaultCharacterHolderComponent", ComponentsMask = new HECSMask				{					Index = 8,					TypeHashCode = -17579568,				}			}},			{ -2131779644, new ComponentMaskAndIndex {ComponentName = "EnemyComponent", ComponentsMask = new HECSMask				{					Index = 9,					TypeHashCode = -2131779644,				}			}},			{ -1416715012, new ComponentMaskAndIndex {ComponentName = "EnemyTagComponent", ComponentsMask = new HECSMask				{					Index = 10,					TypeHashCode = -1416715012,				}			}},			{ 1389512473, new ComponentMaskAndIndex {ComponentName = "GroundCheckComponent", ComponentsMask = new HECSMask				{					Index = 11,					TypeHashCode = 1389512473,				}			}},			{ -589508998, new ComponentMaskAndIndex {ComponentName = "HealthComponent", ComponentsMask = new HECSMask				{					Index = 12,					TypeHashCode = -589508998,				}			}},			{ -1302026474, new ComponentMaskAndIndex {ComponentName = "MovementComponent", ComponentsMask = new HECSMask				{					Index = 13,					TypeHashCode = -1302026474,				}			}},			{ -1036563749, new ComponentMaskAndIndex {ComponentName = "MoveVectorComponent", ComponentsMask = new HECSMask				{					Index = 14,					TypeHashCode = -1036563749,				}			}},			{ -1531631635, new ComponentMaskAndIndex {ComponentName = "MovingPlatformComponent", ComponentsMask = new HECSMask				{					Index = 15,					TypeHashCode = -1531631635,				}			}},			{ -931447152, new ComponentMaskAndIndex {ComponentName = "Rigidbody2DProviderComponent", ComponentsMask = new HECSMask				{					Index = 16,					TypeHashCode = -931447152,				}			}},			{ -1143404840, new ComponentMaskAndIndex {ComponentName = "SpawnPointTagComponent", ComponentsMask = new HECSMask				{					Index = 17,					TypeHashCode = -1143404840,				}			}},			{ 597019103, new ComponentMaskAndIndex {ComponentName = "SpriteRendererProviderComponent", ComponentsMask = new HECSMask				{					Index = 18,					TypeHashCode = 597019103,				}			}},			{ -1227376375, new ComponentMaskAndIndex {ComponentName = "VelocityComponent", ComponentsMask = new HECSMask				{					Index = 19,					TypeHashCode = -1227376375,				}			}},			{ 369067176, new ComponentMaskAndIndex {ComponentName = "SavePositionComponent", ComponentsMask = new HECSMask				{					Index = 20,					TypeHashCode = 369067176,				}			}},			{ -1029564515, new ComponentMaskAndIndex {ComponentName = "ViewReferenceComponent", ComponentsMask = new HECSMask				{					Index = 21,					TypeHashCode = -1029564515,				}			}},			{ -942979946, new ComponentMaskAndIndex {ComponentName = "ActionsHolderComponent", ComponentsMask = new HECSMask				{					Index = 22,					TypeHashCode = -942979946,				}			}},			{ 313621202, new ComponentMaskAndIndex {ComponentName = "AbilityOwnerComponent", ComponentsMask = new HECSMask				{					Index = 23,					TypeHashCode = 313621202,				}			}},			{ 1878456296, new ComponentMaskAndIndex {ComponentName = "AbilityPredicateComponent", ComponentsMask = new HECSMask				{					Index = 24,					TypeHashCode = 1878456296,				}			}},			{ -142928435, new ComponentMaskAndIndex {ComponentName = "ActorContainerID", ComponentsMask = new HECSMask				{					Index = 25,					TypeHashCode = -142928435,				}			}},			{ -803245354, new ComponentMaskAndIndex {ComponentName = "ActorProviderComponent", ComponentsMask = new HECSMask				{					Index = 26,					TypeHashCode = -803245354,				}			}},			{ -988064901, new ComponentMaskAndIndex {ComponentName = "AppVersionComponent", ComponentsMask = new HECSMask				{					Index = 27,					TypeHashCode = -988064901,				}			}},			{ 1354058828, new ComponentMaskAndIndex {ComponentName = "PoolableTagComponent", ComponentsMask = new HECSMask				{					Index = 28,					TypeHashCode = 1354058828,				}			}},			{ -1064941338, new ComponentMaskAndIndex {ComponentName = "PredicatesComponent", ComponentsMask = new HECSMask				{					Index = 29,					TypeHashCode = -1064941338,				}			}},			{ -950198728, new ComponentMaskAndIndex {ComponentName = "AnimatorStateComponent", ComponentsMask = new HECSMask				{					Index = 30,					TypeHashCode = -950198728,				}			}},			{ -1627736277, new ComponentMaskAndIndex {ComponentName = "CountersHolderComponent", ComponentsMask = new HECSMask				{					Index = 31,					TypeHashCode = -1627736277,				}			}},			{ -1713719609, new ComponentMaskAndIndex {ComponentName = "TestSerializationComponent", ComponentsMask = new HECSMask				{					Index = 32,					TypeHashCode = -1713719609,				}			}},			{ 888932549, new ComponentMaskAndIndex {ComponentName = "TransformComponent", ComponentsMask = new HECSMask				{					Index = 33,					TypeHashCode = 888932549,				}			}},			{ -952149029, new ComponentMaskAndIndex {ComponentName = "AIStrategyComponent", ComponentsMask = new HECSMask				{					Index = 34,					TypeHashCode = -952149029,				}			}},			{ 867896372, new ComponentMaskAndIndex {ComponentName = "WaitStateComponent", ComponentsMask = new HECSMask				{					Index = 35,					TypeHashCode = 867896372,				}			}},			{ -1378915465, new ComponentMaskAndIndex {ComponentName = "CacheCounterValuesComponent", ComponentsMask = new HECSMask				{					Index = 36,					TypeHashCode = -1378915465,				}			}},			{ 1143262242, new ComponentMaskAndIndex {ComponentName = "UntilSuccessStrategyNodeComponent", ComponentsMask = new HECSMask				{					Index = 37,					TypeHashCode = 1143262242,				}			}},			{ 2041590961, new ComponentMaskAndIndex {ComponentName = "AbilitiesHolderComponent", ComponentsMask = new HECSMask				{					Index = 38,					TypeHashCode = 2041590961,				}			}},			{ 274782965, new ComponentMaskAndIndex {ComponentName = "AdditionalAbilityIndexComponent", ComponentsMask = new HECSMask				{					Index = 39,					TypeHashCode = 274782965,				}			}},			{ 53484848, new ComponentMaskAndIndex {ComponentName = "AfterLifeCompleteTagComponent", ComponentsMask = new HECSMask				{					Index = 40,					TypeHashCode = 53484848,				}			}},			{ -88497250, new ComponentMaskAndIndex {ComponentName = "AfterLifeTagComponent", ComponentsMask = new HECSMask				{					Index = 41,					TypeHashCode = -88497250,				}			}},			{ -100950956, new ComponentMaskAndIndex {ComponentName = "GameLogicTagComponent", ComponentsMask = new HECSMask				{					Index = 42,					TypeHashCode = -100950956,				}			}},			{ 369850288, new ComponentMaskAndIndex {ComponentName = "InputActionsComponent", ComponentsMask = new HECSMask				{					Index = 43,					TypeHashCode = 369850288,				}			}},			{ 1776997060, new ComponentMaskAndIndex {ComponentName = "InputListenerTagComponent", ComponentsMask = new HECSMask				{					Index = 44,					TypeHashCode = 1776997060,				}			}},			{ 1004631539, new ComponentMaskAndIndex {ComponentName = "ItemTagComponent", ComponentsMask = new HECSMask				{					Index = 45,					TypeHashCode = 1004631539,				}			}},			{ 117603503, new ComponentMaskAndIndex {ComponentName = "NavMeshAgentComponent", ComponentsMask = new HECSMask				{					Index = 46,					TypeHashCode = 117603503,				}			}},			{ 1908646573, new ComponentMaskAndIndex {ComponentName = "NetworkEntityTagComponent", ComponentsMask = new HECSMask				{					Index = 47,					TypeHashCode = 1908646573,				}			}},			{ -1535532641, new ComponentMaskAndIndex {ComponentName = "PoolableViewsProviderComponent", ComponentsMask = new HECSMask				{					Index = 48,					TypeHashCode = -1535532641,				}			}},			{ 265593849, new ComponentMaskAndIndex {ComponentName = "TimeProviderComponent", ComponentsMask = new HECSMask				{					Index = 49,					TypeHashCode = 265593849,				}			}},			{ -1162002111, new ComponentMaskAndIndex {ComponentName = "UIGroupTagComponent", ComponentsMask = new HECSMask				{					Index = 50,					TypeHashCode = -1162002111,				}			}},			{ 1908410989, new ComponentMaskAndIndex {ComponentName = "UIViewReferenceComponent", ComponentsMask = new HECSMask				{					Index = 51,					TypeHashCode = 1908410989,				}			}},			{ -1206519595, new ComponentMaskAndIndex {ComponentName = "UnityRectTransformComponent", ComponentsMask = new HECSMask				{					Index = 52,					TypeHashCode = -1206519595,				}			}},			{ -1425063609, new ComponentMaskAndIndex {ComponentName = "UnityTransformComponent", ComponentsMask = new HECSMask				{					Index = 53,					TypeHashCode = -1425063609,				}			}},			{ 42315994, new ComponentMaskAndIndex {ComponentName = "ViewDestructionDelayedComponent", ComponentsMask = new HECSMask				{					Index = 54,					TypeHashCode = 42315994,				}			}},			{ 1656499746, new ComponentMaskAndIndex {ComponentName = "ViewReferenceGameObjectComponent", ComponentsMask = new HECSMask				{					Index = 55,					TypeHashCode = 1656499746,				}			}},			{ 1587816967, new ComponentMaskAndIndex {ComponentName = "SoundVolumeComponent", ComponentsMask = new HECSMask				{					Index = 56,					TypeHashCode = 1587816967,				}			}},			{ -1325613894, new ComponentMaskAndIndex {ComponentName = "CheckTwoComponent", ComponentsMask = new HECSMask				{					Index = 57,					TypeHashCode = -1325613894,				}			}},			{ 815927063, new ComponentMaskAndIndex {ComponentName = "TestReactComponent", ComponentsMask = new HECSMask				{					Index = 58,					TypeHashCode = 815927063,				}			}},			{ -1150856501, new ComponentMaskAndIndex {ComponentName = "AbilityTagComponent", ComponentsMask = new HECSMask				{					Index = 59,					TypeHashCode = -1150856501,				}			}},			{ -1856633313, new ComponentMaskAndIndex {ComponentName = "PassiveAbilityTag", ComponentsMask = new HECSMask				{					Index = 60,					TypeHashCode = -1856633313,				}			}},			{ -1965185654, new ComponentMaskAndIndex {ComponentName = "ScenarioAnimationComponent", ComponentsMask = new HECSMask				{					Index = 61,					TypeHashCode = -1965185654,				}			}},			{ 387690372, new ComponentMaskAndIndex {ComponentName = "StateContextComponent", ComponentsMask = new HECSMask				{					Index = 62,					TypeHashCode = 387690372,				}			}},			{ 760681168, new ComponentMaskAndIndex {ComponentName = "StateDataComponent", ComponentsMask = new HECSMask				{					Index = 63,					TypeHashCode = 760681168,				}			}},			{ 819793506, new ComponentMaskAndIndex {ComponentName = "StateInfoComponent", ComponentsMask = new HECSMask				{					Index = 64,					TypeHashCode = 819793506,				}			}},			{ 1046176786, new ComponentMaskAndIndex {ComponentName = "AnimationCheckOutsHolderComponent", ComponentsMask = new HECSMask				{					Index = 65,					TypeHashCode = 1046176786,				}			}},			{ -2117687604, new ComponentMaskAndIndex {ComponentName = "OverrideAnimatorComponent", ComponentsMask = new HECSMask				{					Index = 66,					TypeHashCode = -2117687604,				}			}},			{ 1782176358, new ComponentMaskAndIndex {ComponentName = "SetupAfterViewTagComponent", ComponentsMask = new HECSMask				{					Index = 67,					TypeHashCode = 1782176358,				}			}},			{ 7120005, new ComponentMaskAndIndex {ComponentName = "ViewReadyTagComponent", ComponentsMask = new HECSMask				{					Index = 68,					TypeHashCode = 7120005,				}			}},			{ -575221824, new ComponentMaskAndIndex {ComponentName = "RadiusComponent", ComponentsMask = new HECSMask				{					Index = 69,					TypeHashCode = -575221824,				}			}},			{ -1422875746, new ComponentMaskAndIndex {ComponentName = "StickTagComponent", ComponentsMask = new HECSMask				{					Index = 70,					TypeHashCode = -1422875746,				}			}},			{ -1191206187, new ComponentMaskAndIndex {ComponentName = "AdditionalCanvasTagComponent", ComponentsMask = new HECSMask				{					Index = 71,					TypeHashCode = -1191206187,				}			}},			{ -1144719428, new ComponentMaskAndIndex {ComponentName = "MainCanvasTagComponent", ComponentsMask = new HECSMask				{					Index = 72,					TypeHashCode = -1144719428,				}			}},			{ -2124047058, new ComponentMaskAndIndex {ComponentName = "UITagComponent", ComponentsMask = new HECSMask				{					Index = 73,					TypeHashCode = -2124047058,				}			}},			{ 956328563, new ComponentMaskAndIndex {ComponentName = "TestComponent", ComponentsMask = new HECSMask				{					Index = 74,					TypeHashCode = 956328563,				}			}},			{ 2004170910, new ComponentMaskAndIndex {ComponentName = "TestWorldSingleComponent", ComponentsMask = new HECSMask				{					Index = 75,					TypeHashCode = 2004170910,				}			}},			};		}	}	public partial class HECSFactory	{		public HECSFactory()		{			getComponentFromFactoryByHash = GetComponentFromFactoryFunc;			getSystemFromFactoryByHash = GetSystemFromFactoryFunc;		}		private IComponent GetComponentFromFactoryFunc(int hashCodeType)		{			switch (hashCodeType)			{				case 891356082:					return new AnimationComponent();				case -596259457:					return new AttackComponent();				case -611987101:					return new CameraComponent();				case -1555258315:					return new CameraProviderComponent();				case 889396852:					return new CharacterComponent();				case 37992040:					return new CharacterTagComponent();				case -623718192:					return new DamageComponent();				case -17579568:					return new DefaultCharacterHolderComponent();				case -2131779644:					return new EnemyComponent();				case -1416715012:					return new EnemyTagComponent();				case 1389512473:					return new GroundCheckComponent();				case -589508998:					return new HealthComponent();				case -1302026474:					return new MovementComponent();				case -1036563749:					return new MoveVectorComponent();				case -1531631635:					return new MovingPlatformComponent();				case -931447152:					return new Rigidbody2DProviderComponent();				case -1143404840:					return new SpawnPointTagComponent();				case 597019103:					return new SpriteRendererProviderComponent();				case -1227376375:					return new VelocityComponent();				case 369067176:					return new SavePositionComponent();				case -1029564515:					return new ViewReferenceComponent();				case -942979946:					return new ActionsHolderComponent();				case 313621202:					return new AbilityOwnerComponent();				case 1878456296:					return new AbilityPredicateComponent();				case -142928435:					return new ActorContainerID();				case -803245354:					return new ActorProviderComponent();				case -988064901:					return new AppVersionComponent();				case 1354058828:					return new PoolableTagComponent();				case -1064941338:					return new PredicatesComponent();				case -950198728:					return new AnimatorStateComponent();				case -1627736277:					return new CountersHolderComponent();				case -1713719609:					return new TestSerializationComponent();				case 888932549:					return new TransformComponent();				case -952149029:					return new AIStrategyComponent();				case 867896372:					return new WaitStateComponent();				case -1378915465:					return new CacheCounterValuesComponent();				case 1143262242:					return new UntilSuccessStrategyNodeComponent();				case 2041590961:					return new AbilitiesHolderComponent();				case 274782965:					return new AdditionalAbilityIndexComponent();				case 53484848:					return new AfterLifeCompleteTagComponent();				case -88497250:					return new AfterLifeTagComponent();				case -100950956:					return new GameLogicTagComponent();				case 369850288:					return new InputActionsComponent();				case 1776997060:					return new InputListenerTagComponent();				case 1004631539:					return new ItemTagComponent();				case 117603503:					return new NavMeshAgentComponent();				case 1908646573:					return new NetworkEntityTagComponent();				case -1535532641:					return new PoolableViewsProviderComponent();				case 265593849:					return new TimeProviderComponent();				case -1162002111:					return new UIGroupTagComponent();				case 1908410989:					return new UIViewReferenceComponent();				case -1206519595:					return new UnityRectTransformComponent();				case -1425063609:					return new UnityTransformComponent();				case 42315994:					return new ViewDestructionDelayedComponent();				case 1656499746:					return new ViewReferenceGameObjectComponent();				case 1587816967:					return new SoundVolumeComponent();				case -1325613894:					return new CheckTwoComponent();				case 815927063:					return new TestReactComponent();				case -1150856501:					return new AbilityTagComponent();				case -1856633313:					return new PassiveAbilityTag();				case -1965185654:					return new ScenarioAnimationComponent();				case 387690372:					return new StateContextComponent();				case 760681168:					return new StateDataComponent();				case 819793506:					return new StateInfoComponent();				case 1046176786:					return new AnimationCheckOutsHolderComponent();				case -2117687604:					return new OverrideAnimatorComponent();				case 1782176358:					return new SetupAfterViewTagComponent();				case 7120005:					return new ViewReadyTagComponent();				case -575221824:					return new RadiusComponent();				case -1422875746:					return new StickTagComponent();				case -1191206187:					return new AdditionalCanvasTagComponent();				case -1144719428:					return new MainCanvasTagComponent();				case -2124047058:					return new UITagComponent();				case 956328563:					return new TestComponent();				case 2004170910:					return new TestWorldSingleComponent();			}			return default;		}		private ISystem GetSystemFromFactoryFunc(int hashCodeType)		{			switch (hashCodeType)			{				case -1605596048:					return new CharacterCameraFollowingSystem();								case 1343384673:					return new CharacterDeathSystem();				case -1385743281:					return new CharacterMovementSystem();				case -1529194874:					return new CharacterMovingAnimationSystem();				case -1121825076:					return new DeathSystem();				case -224448793:					return new EnemyMovementAnimationSystem();				case -981783809:					return new EnemyMovementSystem();				case -1294994440:					return new PlatformCatchSystem();				case 1593372548:					return new PlatformMovingSystem();				case -1593124541:					return new SpawnDefaultCharacterSystem();				case -579706225:					return new AbilitiesSystem();				case 1506818367:					return new AwaitersUpdateSystem();				case -1857160786:					return new DestroyEntityWorldSystem();				case 889578405:					return new PoolingSystem();				case -1795809721:					return new RemoveComponentWorldSystem();				case -646677924:					return new WaitingCommandsSystems();				case -1199486581:					return new AINPCSystem();				case 1511774883:					return new ActorAfterViewSystem();				case -1273150962:					return new InputListenSystem();				case -585996021:					return new SpawnViewSystem();				case -1087811633:					return new StartSystem();				case -1277883239:					return new UpdateActorByTranformSystem();				case 612152530:					return new UpdateTranformFromActorSystem();				case -1459275698:					return new SoundGlobalSystem();				case -929402950:					return new StressTestReactsSystem();				case -2046803395:					return new AdditionalCanvasesSystem();				case -315138388:					return new HideUISystem();				case 1256894449:					return new UISystem();				case 1551745777:					return new CountersHolderSystem();				case -1366223974:					return new StateUpdateSystem();				case -1817032501:					return new StrategiesMainServiceSystem();				case 2115456507:					return new AnimationDoneCheckOutSystem();				case -1261367218:					return new StickFollowSystem();				case 1144389691:					return new StickInputSystem();				case -1418447923:					return new TouchScreenSystem();				case -2069977297:					return new CompositeAbilitiesSystem();				case -561225003:					return new AnimationSystem();			}			return default;		}	}}