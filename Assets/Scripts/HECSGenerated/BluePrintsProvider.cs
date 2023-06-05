using Components;using System;using Systems;using System.Collections.Generic;namespace HECSFramework.Unity{	public partial class BluePrintsProvider	{		public BluePrintsProvider()		{		Components = new Dictionary<Type, Type>		{			 { typeof(AnimationComponent), typeof(AnimationComponentBluePrint) },			 { typeof(AttackComponent), typeof(AttackComponentBluePrint) },			 { typeof(CameraComponent), typeof(CameraComponentBluePrint) },			 { typeof(CameraProviderComponent), typeof(CameraProviderComponentBluePrint) },			 { typeof(CharacterComponent), typeof(CharacterComponentBluePrint) },			 { typeof(CharacterTagComponent), typeof(CharacterTagComponentBluePrint) },			 { typeof(Collider2dProviderComponent), typeof(Collider2dProviderComponentBluePrint) },			 { typeof(CollisionTargetsComponent), typeof(CollisionTargetsComponentBluePrint) },			 { typeof(DamageComponent), typeof(DamageComponentBluePrint) },			 { typeof(DefaultCharacterHolderComponent), typeof(DefaultCharacterHolderComponentBluePrint) },			 { typeof(EnemyBehaviourComponent), typeof(EnemyBehaviourComponentBluePrint) },			 { typeof(EnemyComponent), typeof(EnemyComponentBluePrint) },			 { typeof(EnemyHolderComponent), typeof(EnemyHolderComponentBluePrint) },			 { typeof(EnemySpawnPointTagComponent), typeof(EnemySpawnPointTagComponentBluePrint) },			 { typeof(EnemyTagComponent), typeof(EnemyTagComponentBluePrint) },			 { typeof(GroundCheckComponent), typeof(GroundCheckComponentBluePrint) },			 { typeof(HealthComponent), typeof(HealthComponentBluePrint) },			 { typeof(MovementComponent), typeof(MovementComponentBluePrint) },			 { typeof(MoveVectorComponent), typeof(MoveVectorComponentBluePrint) },			 { typeof(MovingPlatformComponent), typeof(MovingPlatformComponentBluePrint) },			 { typeof(Rigidbody2DProviderComponent), typeof(Rigidbody2DProviderComponentBluePrint) },			 { typeof(SpawnPointTagComponent), typeof(SpawnPointTagComponentBluePrint) },			 { typeof(SpriteRendererProviderComponent), typeof(SpriteRendererProviderComponentBluePrint) },			 { typeof(VelocityComponent), typeof(VelocityComponentBluePrint) },			 { typeof(SavePositionComponent), typeof(SavePositionComponentBluePrint) },			 { typeof(ViewReferenceComponent), typeof(ViewReferenceComponentBluePrint) },			 { typeof(ActionsHolderComponent), typeof(ActionsHolderComponentBluePrint) },			 { typeof(AbilityOwnerComponent), typeof(AbilityOwnerComponentBluePrint) },			 { typeof(AbilityPredicateComponent), typeof(AbilityPredicateComponentBluePrint) },			 { typeof(ActorContainerID), typeof(ActorContainerIDBluePrint) },			 { typeof(ActorProviderComponent), typeof(ActorProviderComponentBluePrint) },			 { typeof(AppVersionComponent), typeof(AppVersionComponentBluePrint) },			 { typeof(PoolableTagComponent), typeof(PoolableTagComponentBluePrint) },			 { typeof(PredicatesComponent), typeof(PredicatesComponentBluePrint) },			 { typeof(AnimatorStateComponent), typeof(AnimatorStateComponentBluePrint) },			 { typeof(CountersHolderComponent), typeof(CountersHolderComponentBluePrint) },			 { typeof(TestSerializationComponent), typeof(TestSerializationComponentBluePrint) },			 { typeof(TransformComponent), typeof(TransformComponentBluePrint) },			 { typeof(AIStrategyComponent), typeof(AIStrategyComponentBluePrint) },			 { typeof(WaitStateComponent), typeof(WaitStateComponentBluePrint) },			 { typeof(CacheCounterValuesComponent), typeof(CacheCounterValuesComponentBluePrint) },			 { typeof(UntilSuccessStrategyNodeComponent), typeof(UntilSuccessStrategyNodeComponentBluePrint) },			 { typeof(AbilitiesHolderComponent), typeof(AbilitiesHolderComponentBluePrint) },			 { typeof(AdditionalAbilityIndexComponent), typeof(AdditionalAbilityIndexComponentBluePrint) },			 { typeof(AfterLifeCompleteTagComponent), typeof(AfterLifeCompleteTagComponentBluePrint) },			 { typeof(AfterLifeTagComponent), typeof(AfterLifeTagComponentBluePrint) },			 { typeof(GameLogicTagComponent), typeof(GameLogicTagComponentBluePrint) },			 { typeof(InputActionsComponent), typeof(InputActionsComponentBluePrint) },			 { typeof(InputListenerTagComponent), typeof(InputListenerTagComponentBluePrint) },			 { typeof(ItemTagComponent), typeof(ItemTagComponentBluePrint) },			 { typeof(NavMeshAgentComponent), typeof(NavMeshAgentComponentBluePrint) },			 { typeof(NetworkEntityTagComponent), typeof(NetworkEntityTagComponentBluePrint) },			 { typeof(PoolableViewsProviderComponent), typeof(PoolableViewsProviderComponentBluePrint) },			 { typeof(TimeProviderComponent), typeof(TimeProviderComponentBluePrint) },			 { typeof(UIGroupTagComponent), typeof(UIGroupTagComponentBluePrint) },			 { typeof(UIViewReferenceComponent), typeof(UIViewReferenceComponentBluePrint) },			 { typeof(UnityRectTransformComponent), typeof(UnityRectTransformComponentBluePrint) },			 { typeof(UnityTransformComponent), typeof(UnityTransformComponentBluePrint) },			 { typeof(ViewDestructionDelayedComponent), typeof(ViewDestructionDelayedComponentBluePrint) },			 { typeof(ViewReferenceGameObjectComponent), typeof(ViewReferenceGameObjectComponentBluePrint) },			 { typeof(SoundVolumeComponent), typeof(SoundVolumeComponentBluePrint) },			 { typeof(CheckTwoComponent), typeof(CheckTwoComponentBluePrint) },			 { typeof(TestReactComponent), typeof(TestReactComponentBluePrint) },			 { typeof(AbilityTagComponent), typeof(AbilityTagComponentBluePrint) },			 { typeof(PassiveAbilityTag), typeof(PassiveAbilityTagBluePrint) },			 { typeof(ScenarioAnimationComponent), typeof(ScenarioAnimationComponentBluePrint) },			 { typeof(StateContextComponent), typeof(StateContextComponentBluePrint) },			 { typeof(StateDataComponent), typeof(StateDataComponentBluePrint) },			 { typeof(StateInfoComponent), typeof(StateInfoComponentBluePrint) },			 { typeof(AnimationCheckOutsHolderComponent), typeof(AnimationCheckOutsHolderComponentBluePrint) },			 { typeof(OverrideAnimatorComponent), typeof(OverrideAnimatorComponentBluePrint) },			 { typeof(SetupAfterViewTagComponent), typeof(SetupAfterViewTagComponentBluePrint) },			 { typeof(ViewReadyTagComponent), typeof(ViewReadyTagComponentBluePrint) },			 { typeof(RadiusComponent), typeof(RadiusComponentBluePrint) },			 { typeof(StickTagComponent), typeof(StickTagComponentBluePrint) },			 { typeof(AdditionalCanvasTagComponent), typeof(AdditionalCanvasTagComponentBluePrint) },			 { typeof(MainCanvasTagComponent), typeof(MainCanvasTagComponentBluePrint) },			 { typeof(UITagComponent), typeof(UITagComponentBluePrint) },			 { typeof(TestComponent), typeof(TestComponentBluePrint) },			 { typeof(TestWorldSingleComponent), typeof(TestWorldSingleComponentBluePrint) },		};		Systems = new Dictionary<Type, Type>		{			 { typeof(CharacterAttackSystem), typeof(CharacterAttackSystemBluePrint) },			 { typeof(CharacterCameraFollowingSystem), typeof(CharacterCameraFollowingSystemBluePrint) },			 { typeof(CharacterDeathSystem), typeof(CharacterDeathSystemBluePrint) },			 { typeof(CharacterMovementSystem), typeof(CharacterMovementSystemBluePrint) },			 { typeof(CharacterMovingAnimationSystem), typeof(CharacterMovingAnimationSystemBluePrint) },			 { typeof(DealDamageSystemSystem), typeof(DealDamageSystemSystemBluePrint) },			 { typeof(DeathSystem), typeof(DeathSystemBluePrint) },			 { typeof(EnemyBehaviourSystem), typeof(EnemyBehaviourSystemBluePrint) },			 { typeof(HealthChangeSystem), typeof(HealthChangeSystemBluePrint) },			 { typeof(PlatformCatchSystem), typeof(PlatformCatchSystemBluePrint) },			 { typeof(PlatformMovingSystem), typeof(PlatformMovingSystemBluePrint) },			 { typeof(SpawnDefaultCharacterSystem), typeof(SpawnDefaultCharacterSystemBluePrint) },			 { typeof(SpawnEnemySystem), typeof(SpawnEnemySystemBluePrint) },			 { typeof(AbilitiesSystem), typeof(AbilitiesSystemBluePrint) },			 { typeof(AwaitersUpdateSystem), typeof(AwaitersUpdateSystemBluePrint) },			 { typeof(DestroyEntityWorldSystem), typeof(DestroyEntityWorldSystemBluePrint) },			 { typeof(PoolingSystem), typeof(PoolingSystemBluePrint) },			 { typeof(RemoveComponentWorldSystem), typeof(RemoveComponentWorldSystemBluePrint) },			 { typeof(WaitingCommandsSystems), typeof(WaitingCommandsSystemsBluePrint) },			 { typeof(AINPCSystem), typeof(AINPCSystemBluePrint) },			 { typeof(ActorAfterViewSystem), typeof(ActorAfterViewSystemBluePrint) },			 { typeof(InputListenSystem), typeof(InputListenSystemBluePrint) },			 { typeof(SpawnViewSystem), typeof(SpawnViewSystemBluePrint) },			 { typeof(StartSystem), typeof(StartSystemBluePrint) },			 { typeof(UpdateActorByTranformSystem), typeof(UpdateActorByTranformSystemBluePrint) },			 { typeof(UpdateTranformFromActorSystem), typeof(UpdateTranformFromActorSystemBluePrint) },			 { typeof(SoundGlobalSystem), typeof(SoundGlobalSystemBluePrint) },			 { typeof(StressTestReactsSystem), typeof(StressTestReactsSystemBluePrint) },			 { typeof(AdditionalCanvasesSystem), typeof(AdditionalCanvasesSystemBluePrint) },			 { typeof(HideUISystem), typeof(HideUISystemBluePrint) },			 { typeof(UISystem), typeof(UISystemBluePrint) },			 { typeof(CountersHolderSystem), typeof(CountersHolderSystemBluePrint) },			 { typeof(StateUpdateSystem), typeof(StateUpdateSystemBluePrint) },			 { typeof(StrategiesMainServiceSystem), typeof(StrategiesMainServiceSystemBluePrint) },			 { typeof(AnimationDoneCheckOutSystem), typeof(AnimationDoneCheckOutSystemBluePrint) },			 { typeof(StickFollowSystem), typeof(StickFollowSystemBluePrint) },			 { typeof(StickInputSystem), typeof(StickInputSystemBluePrint) },			 { typeof(TouchScreenSystem), typeof(TouchScreenSystemBluePrint) },			 { typeof(CompositeAbilitiesSystem), typeof(CompositeAbilitiesSystemBluePrint) },			 { typeof(AnimationSystem), typeof(AnimationSystemBluePrint) },		};		}	}}