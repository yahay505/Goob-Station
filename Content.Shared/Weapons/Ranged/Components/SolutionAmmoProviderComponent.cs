// SPDX-FileCopyrightText: 2023 IProduceWidgets <107586145+IProduceWidgets@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 ElectroJr <leonsfriedrich@gmail.com>
// SPDX-FileCopyrightText: 2024 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Weapons.Ranged.Systems;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.Weapons.Ranged.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(fieldDeltas: true), Access(typeof(SharedGunSystem))]
public sealed partial class SolutionAmmoProviderComponent : Component
{
    /// <summary>
    /// The solution where reagents are extracted from for the projectile.
    /// </summary>
    [DataField(required: true), AutoNetworkedField]
    public string SolutionId = default!;

    /// <summary>
    /// How much reagent it costs to fire once.
    /// </summary>
    [DataField, AutoNetworkedField]
    public float FireCost = 5;

    /// <summary>
    /// The amount of shots currently available.
    /// used for network predictions.
    /// </summary>
    [DataField, AutoNetworkedField]
    public int Shots;

    /// <summary>
    /// The max amount of shots the gun can fire.
    /// used for network prediction
    /// </summary>
    [DataField, AutoNetworkedField]
    public int MaxShots;

    /// <summary>
    /// The prototype that's fired by the gun.
    /// </summary>
    [DataField("proto")]
    public EntProtoId Prototype;
}