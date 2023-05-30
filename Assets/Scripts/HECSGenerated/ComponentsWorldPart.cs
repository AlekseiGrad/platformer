using Components;namespace HECSFramework.Core{	public partial class World	{		partial void FillRegistrators()		{			componentProviderRegistrators = new ComponentProviderRegistrator[]			{				new ComponentProviderRegistrator<CameraComponent>(),				new ComponentProviderRegistrator<CameraProviderComponent>(),				new ComponentProviderRegistrator<CharacterComponent>(),				new ComponentProviderRegistrator<DamageComponent>(),				new ComponentProviderRegistrator<DefaultCharacterHolderComponent>(),				new ComponentProviderRegistrator<HealthComponent>(),				new ComponentProviderRegistrator<MovingPlatformComponent>(),				new ComponentProviderRegistrator<Rigidbody2DProviderComponent>(),				new ComponentProviderRegistrator<SpawnPointTagComponent>(),				new ComponentProviderRegistrator<SavePositionComponent>(),				new ComponentProviderRegistrator<ViewReferenceComponent>(),				new ComponentProviderRegistrator<ActionsHolderComponent>(),				new ComponentProviderRegistrator<AbilityOwnerComponent>(),				new ComponentProviderRegistrator<AbilityPredicateComponent>(),				new ComponentProviderRegistrator<ActorContainerID>(),				new ComponentProviderRegistrator<ActorProviderComponent>(),				new ComponentProviderRegistrator<AppVersionComponent>(),				new ComponentProviderRegistrator<PoolableTagComponent>(),				new ComponentProviderRegistrator<PredicatesComponent>(),				new ComponentProviderRegistrator<AnimatorStateComponent>(),				new ComponentProviderRegistrator<CountersHolderComponent>(),				new ComponentProviderRegistrator<TestSerializationComponent>(),				new ComponentProviderRegistrator<TransformComponent>(),				new ComponentProviderRegistrator<AIStrategyComponent>(),				new ComponentProviderRegistrator<WaitStateComponent>(),				new ComponentProviderRegistrator<CacheCounterValuesComponent>(),				new ComponentProviderRegistrator<UntilSuccessStrategyNodeComponent>(),				new ComponentProviderRegistrator<AbilitiesHolderComponent>(),				new ComponentProviderRegistrator<AdditionalAbilityIndexComponent>(),				new ComponentProviderRegistrator<AfterLifeCompleteTagComponent>(),				new ComponentProviderRegistrator<AfterLifeTagComponent>(),				new ComponentProviderRegistrator<GameLogicTagComponent>(),				new ComponentProviderRegistrator<InputActionsComponent>(),				new ComponentProviderRegistrator<InputListenerTagComponent>(),				new ComponentProviderRegistrator<ItemTagComponent>(),				new ComponentProviderRegistrator<NavMeshAgentComponent>(),				new ComponentProviderRegistrator<NetworkEntityTagComponent>(),				new ComponentProviderRegistrator<PoolableViewsProviderComponent>(),				new ComponentProviderRegistrator<TimeProviderComponent>(),				new ComponentProviderRegistrator<UIGroupTagComponent>(),				new ComponentProviderRegistrator<UIViewReferenceComponent>(),				new ComponentProviderRegistrator<UnityRectTransformComponent>(),				new ComponentProviderRegistrator<UnityTransformComponent>(),				new ComponentProviderRegistrator<ViewDestructionDelayedComponent>(),				new ComponentProviderRegistrator<ViewReferenceGameObjectComponent>(),				new ComponentProviderRegistrator<SoundVolumeComponent>(),				new ComponentProviderRegistrator<CheckTwoComponent>(),				new ComponentProviderRegistrator<TestReactComponent>(),				new ComponentProviderRegistrator<AbilityTagComponent>(),				new ComponentProviderRegistrator<PassiveAbilityTag>(),				new ComponentProviderRegistrator<ScenarioAnimationComponent>(),				new ComponentProviderRegistrator<StateContextComponent>(),				new ComponentProviderRegistrator<StateDataComponent>(),				new ComponentProviderRegistrator<StateInfoComponent>(),				new ComponentProviderRegistrator<AnimationCheckOutsHolderComponent>(),				new ComponentProviderRegistrator<OverrideAnimatorComponent>(),				new ComponentProviderRegistrator<SetupAfterViewTagComponent>(),				new ComponentProviderRegistrator<ViewReadyTagComponent>(),				new ComponentProviderRegistrator<RadiusComponent>(),				new ComponentProviderRegistrator<StickTagComponent>(),				new ComponentProviderRegistrator<AdditionalCanvasTagComponent>(),				new ComponentProviderRegistrator<MainCanvasTagComponent>(),				new ComponentProviderRegistrator<UITagComponent>(),				new ComponentProviderRegistrator<TestComponent>(),				new ComponentProviderRegistrator<TestWorldSingleComponent>(),			};		}	}}