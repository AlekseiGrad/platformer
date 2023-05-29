using Components;using System;using Systems;using System.Collections.Generic;namespace HECSFramework.Unity{	public partial class BluePrintsProvider	{		public BluePrintsProvider()		{		Components = new Dictionary<Type, Type>		{			 { typeof(CameraComponent), typeof(CameraComponentBluePrint) },			 { typeof(Rigidbody2DProviderComponent), typeof(Rigidbody2DProviderComponentBluePrint) },			 { typeof(CharacterComponent), typeof(CharacterComponentBluePrint) },			 { typeof(DefaultCharacterHolderComponent), typeof(DefaultCharacterHolderComponentBluePrint) },			 { typeof(CameraProviderComponent), typeof(CameraProviderComponentBluePrint) },			 { typeof(SpawnPointTagComponent), typeof(SpawnPointTagComponentBluePrint) },			 { typeof(MovingPlatformComponent), typeof(MovingPlatformComponentBluePrint) },			 { typeof(SavePositionComponent), typeof(SavePositionComponentBluePrint) },			 { typeof(ViewReferenceComponent), typeof(ViewReferenceComponentBluePrint) },			 { typeof(ActorProviderComponent), typeof(ActorProviderComponentBluePrint) },			 { typeof(TestReactComponent), typeof(TestReactComponentBluePrint) },			 { typeof(CheckTwoComponent), typeof(CheckTwoComponentBluePrint) },			 { typeof(AbilitiesHolderComponent), typeof(AbilitiesHolderComponentBluePrint) },			 { typeof(AdditionalAbilityIndexComponent), typeof(AdditionalAbilityIndexComponentBluePrint) },			 { typeof(ActionsHolderComponent), typeof(ActionsHolderComponentBluePrint) },			 { typeof(SoundVolumeComponent), typeof(SoundVolumeComponentBluePrint) },			 { typeof(PredicatesComponent), typeof(PredicatesComponentBluePrint) },			 { typeof(NavMeshAgentComponent), typeof(NavMeshAgentComponentBluePrint) },			 { typeof(PoolableTagComponent), typeof(PoolableTagComponentBluePrint) },			 { typeof(GameLogicTagComponent), typeof(GameLogicTagComponentBluePrint) },			 { typeof(UIViewReferenceComponent), typeof(UIViewReferenceComponentBluePrint) },			 { typeof(InputActionsComponent), typeof(InputActionsComponentBluePrint) },			 { typeof(ViewReferenceGameObjectComponent), typeof(ViewReferenceGameObjectComponentBluePrint) },			 { typeof(PoolableViewsProviderComponent), typeof(PoolableViewsProviderComponentBluePrint) },			 { typeof(ItemTagComponent), typeof(ItemTagComponentBluePrint) },			 { typeof(TransformComponent), typeof(TransformComponentBluePrint) },			 { typeof(UnityRectTransformComponent), typeof(UnityRectTransformComponentBluePrint) },			 { typeof(UnityTransformComponent), typeof(UnityTransformComponentBluePrint) },			 { typeof(InputListenerTagComponent), typeof(InputListenerTagComponentBluePrint) },			 { typeof(AfterLifeCompleteTagComponent), typeof(AfterLifeCompleteTagComponentBluePrint) },			 { typeof(AfterLifeTagComponent), typeof(AfterLifeTagComponentBluePrint) },			 { typeof(UIGroupTagComponent), typeof(UIGroupTagComponentBluePrint) },			 { typeof(ViewDestructionDelayedComponent), typeof(ViewDestructionDelayedComponentBluePrint) },			 { typeof(TimeProviderComponent), typeof(TimeProviderComponentBluePrint) },			 { typeof(NetworkEntityTagComponent), typeof(NetworkEntityTagComponentBluePrint) },			 { typeof(AbilityOwnerComponent), typeof(AbilityOwnerComponentBluePrint) },			 { typeof(ActorContainerID), typeof(ActorContainerIDBluePrint) },			 { typeof(AbilityPredicateComponent), typeof(AbilityPredicateComponentBluePrint) },			 { typeof(AppVersionComponent), typeof(AppVersionComponentBluePrint) },			 { typeof(CountersHolderComponent), typeof(CountersHolderComponentBluePrint) },			 { typeof(TestSerializationComponent), typeof(TestSerializationComponentBluePrint) },			 { typeof(AnimatorStateComponent), typeof(AnimatorStateComponentBluePrint) },			 { typeof(UntilSuccessStrategyNodeComponent), typeof(UntilSuccessStrategyNodeComponentBluePrint) },			 { typeof(CacheCounterValuesComponent), typeof(CacheCounterValuesComponentBluePrint) },			 { typeof(WaitStateComponent), typeof(WaitStateComponentBluePrint) },			 { typeof(AIStrategyComponent), typeof(AIStrategyComponentBluePrint) },			 { typeof(UITagComponent), typeof(UITagComponentBluePrint) },			 { typeof(MainCanvasTagComponent), typeof(MainCanvasTagComponentBluePrint) },			 { typeof(AdditionalCanvasTagComponent), typeof(AdditionalCanvasTagComponentBluePrint) },			 { typeof(RadiusComponent), typeof(RadiusComponentBluePrint) },			 { typeof(StickTagComponent), typeof(StickTagComponentBluePrint) },			 { typeof(ScenarioAnimationComponent), typeof(ScenarioAnimationComponentBluePrint) },			 { typeof(SetupAfterViewTagComponent), typeof(SetupAfterViewTagComponentBluePrint) },			 { typeof(ViewReadyTagComponent), typeof(ViewReadyTagComponentBluePrint) },			 { typeof(OverrideAnimatorComponent), typeof(OverrideAnimatorComponentBluePrint) },			 { typeof(AnimationCheckOutsHolderComponent), typeof(AnimationCheckOutsHolderComponentBluePrint) },			 { typeof(AbilityTagComponent), typeof(AbilityTagComponentBluePrint) },			 { typeof(PassiveAbilityTag), typeof(PassiveAbilityTagBluePrint) },			 { typeof(StateContextComponent), typeof(StateContextComponentBluePrint) },			 { typeof(StateInfoComponent), typeof(StateInfoComponentBluePrint) },			 { typeof(StateDataComponent), typeof(StateDataComponentBluePrint) },			 { typeof(TestComponent), typeof(TestComponentBluePrint) },			 { typeof(TestWorldSingleComponent), typeof(TestWorldSingleComponentBluePrint) },		};		Systems = new Dictionary<Type, Type>		{			 { typeof(TestTestSystem), typeof(TestTestSystemBluePrint) },			 { typeof(PlatformCatherSystem), typeof(PlatformCatherSystemBluePrint) },			 { typeof(CharacterMovementSystem), typeof(CharacterMovementSystemBluePrint) },			 { typeof(SpawnDefaultCharacterSystem), typeof(SpawnDefaultCharacterSystemBluePrint) },			 { typeof(CharacterCameraFollowingSystem), typeof(CharacterCameraFollowingSystemBluePrint) },			 { typeof(PlatformMovingSystem), typeof(PlatformMovingSystemBluePrint) },			 { typeof(CharacterMovingAnimationSystem), typeof(CharacterMovingAnimationSystemBluePrint) },			 { typeof(HideUISystem), typeof(HideUISystemBluePrint) },			 { typeof(AdditionalCanvasesSystem), typeof(AdditionalCanvasesSystemBluePrint) },			 { typeof(UISystem), typeof(UISystemBluePrint) },			 { typeof(InputListenSystem), typeof(InputListenSystemBluePrint) },			 { typeof(SpawnViewSystem), typeof(SpawnViewSystemBluePrint) },			 { typeof(PoolingSystem), typeof(PoolingSystemBluePrint) },			 { typeof(UpdateActorByTranformSystem), typeof(UpdateActorByTranformSystemBluePrint) },			 { typeof(ActorAfterViewSystem), typeof(ActorAfterViewSystemBluePrint) },			 { typeof(UpdateTranformFromActorSystem), typeof(UpdateTranformFromActorSystemBluePrint) },			 { typeof(StartSystem), typeof(StartSystemBluePrint) },			 { typeof(StressTestReactsSystem), typeof(StressTestReactsSystemBluePrint) },			 { typeof(AbilitiesSystem), typeof(AbilitiesSystemBluePrint) },			 { typeof(SoundGlobalSystem), typeof(SoundGlobalSystemBluePrint) },			 { typeof(AwaitersUpdateSystem), typeof(AwaitersUpdateSystemBluePrint) },			 { typeof(RemoveComponentWorldSystem), typeof(RemoveComponentWorldSystemBluePrint) },			 { typeof(WaitingCommandsSystems), typeof(WaitingCommandsSystemsBluePrint) },			 { typeof(DestroyEntityWorldSystem), typeof(DestroyEntityWorldSystemBluePrint) },			 { typeof(AINPCSystem), typeof(AINPCSystemBluePrint) },			 { typeof(StickFollowSystem), typeof(StickFollowSystemBluePrint) },			 { typeof(TouchScreenSystem), typeof(TouchScreenSystemBluePrint) },			 { typeof(StickInputSystem), typeof(StickInputSystemBluePrint) },			 { typeof(AnimationDoneCheckOutSystem), typeof(AnimationDoneCheckOutSystemBluePrint) },			 { typeof(CountersHolderSystem), typeof(CountersHolderSystemBluePrint) },			 { typeof(StrategiesMainServiceSystem), typeof(StrategiesMainServiceSystemBluePrint) },			 { typeof(StateUpdateSystem), typeof(StateUpdateSystemBluePrint) },			 { typeof(AnimationSystem), typeof(AnimationSystemBluePrint) },			 { typeof(CompositeAbilitiesSystem), typeof(CompositeAbilitiesSystemBluePrint) },		};		}	}}