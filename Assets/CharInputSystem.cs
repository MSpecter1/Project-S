// GENERATED AUTOMATICALLY FROM 'Assets/CharInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharInputSystem : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @CharInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharInputSystem"",
    ""maps"": [
        {
            ""name"": ""FGInputsKeyboard"",
            ""id"": ""c2fee75c-f2ee-4e79-9e09-ffb3fd22a804"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""9033683a-3f63-4b9c-82e4-763cbdb1c54d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""0fd3956d-418b-4eb2-8905-ce1d96493b5f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""62375a01-588f-4af3-9c76-0f7efa170860"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveJump"",
                    ""type"": ""Button"",
                    ""id"": ""f0ce8d93-2f94-423c-9646-5fa2e75b293d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCrouch"",
                    ""type"": ""Button"",
                    ""id"": ""d2e5bbed-f4ae-4a2e-a56e-cec8c4ab264a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackLight"",
                    ""type"": ""Button"",
                    ""id"": ""1e6770d1-b507-4f5c-9598-4fd6e08fef6f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackMedium"",
                    ""type"": ""Button"",
                    ""id"": ""aabd1ce7-6888-40dc-bb33-41a20b566072"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackHeavy"",
                    ""type"": ""Button"",
                    ""id"": ""9ec55469-592f-47fe-b0dd-6bf3b67de7c7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Button"",
                    ""id"": ""25e45bdb-35dc-4fe1-8a1b-3245bfe5e0cd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""4108b033-6b4f-4683-b651-c8bc14c10f5c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""dcdd3206-9378-4541-8784-a3d412506031"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3f34be3c-911b-4b20-b8d8-445679a78388"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea88242b-321d-4dfe-9eb0-121b32633d8a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""175a5c06-66d6-4077-aafa-f78f538ae7cc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6001a38a-1b79-40cf-9d68-513d5bb40eca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCrouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dcab868-0b6a-4b31-b301-9da7be2e9710"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59c75de0-4907-458e-a11e-ba0b7914a011"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackMedium"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70b593e8-31e5-444e-a956-246ca8c12c5a"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackHeavy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f207397a-de67-49a3-a8de-b86533a65880"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcd59993-e5f5-4b06-a7fe-267e01d34909"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaeef8ed-855e-41f5-b900-e679093233ee"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MoveVectors"",
                    ""id"": ""2a507183-1224-4592-980b-82316622a4ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b8932666-a6f1-4506-8396-b42f998f4846"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e529e21-8d48-4e8e-aab0-8dac3a5bdee2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""92634294-29fd-4fb9-9699-a8a635ca2f89"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5c37f9dd-fdad-4406-aad6-cddbbbe80770"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""FGInputsKeyboard2"",
            ""id"": ""b8c4078d-95e1-4d48-bc77-90f5bd5ba16c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""7d8f89d6-a9d8-4015-bfec-851254801d80"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""138f82f8-fc47-4e00-9306-3fdf143e3330"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4c49ec2b-4228-4e42-94b6-917513e0e22b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveJump"",
                    ""type"": ""Button"",
                    ""id"": ""bc6fad55-00c2-417b-ace8-de9df6be07ca"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCrouch"",
                    ""type"": ""Button"",
                    ""id"": ""5c328850-96bc-421c-a203-8537e058249e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackLight"",
                    ""type"": ""Button"",
                    ""id"": ""c0a5d2da-a0a2-437d-ba58-3bc4a67bb3f6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackMedium"",
                    ""type"": ""Button"",
                    ""id"": ""5f08f111-5d5f-46b2-b907-0a689ddcda3d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackHeavy"",
                    ""type"": ""Button"",
                    ""id"": ""a91342c0-cc70-4fcc-88da-9db5c79b301c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Button"",
                    ""id"": ""cbd51e07-1ed8-4f1d-abfc-f1a3ebf2a981"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""a8ed6cff-d46c-47be-8a43-c4d78c232edc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""b1519a10-754d-4e3e-ada5-696c018ca072"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aba56f73-d0ac-442e-864f-57989460048f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53ece2d9-9e70-48a5-940f-0fa168bc04a0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b4b09ad-4d6c-4ddf-90b2-fc334ea394b1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47769c7b-8e4c-45b8-bfef-9550aa3acd96"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCrouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""774c211f-0874-45a9-aa70-f1dfd4bab818"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70fbaae4-6256-4b23-af32-3af6961e687d"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackMedium"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e7cbd22-57a3-4d1d-984f-1a034a1faa11"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackHeavy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8d48973-4af3-4d3e-907d-bcc7f19edd3d"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd833848-2166-44da-811d-ec8bb458cae4"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ac242e8-2fce-4bfd-a3b2-9c3bec4a80f1"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MoveVectors"",
                    ""id"": ""782ecd5d-c24c-466e-93e0-cd6be366793e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7b5d1126-fb8d-4970-baee-1d83506fa180"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d064a8fa-7c1c-4364-bece-5f3a05f1823c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7a39382-56eb-4123-b076-1ffbc5bd42bd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""48ea2370-d174-459b-bf56-e1766350c9d8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""FGInputsController"",
            ""id"": ""fd36a9e9-323d-41a9-a92d-c3b866c4a5eb"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""76dbf828-bf32-4df3-9cd5-bb93d030dcca"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""eda13fc2-99c7-4cbc-b23c-563ce24b8f65"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveJump"",
                    ""type"": ""Button"",
                    ""id"": ""62fa6204-1b29-478f-8768-506817ce0647"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCrouch"",
                    ""type"": ""Button"",
                    ""id"": ""e04d254f-8a72-41e1-9d30-d08e9e370cde"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackLight"",
                    ""type"": ""Button"",
                    ""id"": ""c61d85be-8908-412a-b011-393caae88c78"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackMedium"",
                    ""type"": ""Button"",
                    ""id"": ""8af6c795-bba8-4563-a1ac-f1bf95209d50"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackHeavy"",
                    ""type"": ""Button"",
                    ""id"": ""9d2957e4-cbcb-4b92-a5de-533e2a4eafe9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Button"",
                    ""id"": ""bf9344dd-cf2c-4427-8e00-b1ecf3815fb6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape/Menu"",
                    ""type"": ""Button"",
                    ""id"": ""54eb5834-174f-47d0-9db0-83c770fca7bf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""803ab2a4-417f-456d-8a86-718ed65fc65b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""077ee3ab-b97e-4fbd-a767-c4a362333cf3"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d27f316c-b3e6-4dff-a13a-abd1068613fa"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14cad7d1-93ba-4949-a4a2-842e7d1d11ab"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ed31525-557e-48a5-baeb-6923aadec9c2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCrouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27693b53-627d-4c3d-b473-d4dbd02c9e21"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8eb56001-8fc5-40b4-bd86-68b756d15205"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackMedium"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d52d3ce-b56b-4502-94f4-d13243fb0291"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackHeavy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b342ce0d-cd0c-4e52-b24b-d98dac8cee3b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f759d8d-b77e-4a91-9b79-5575cef0ce73"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape/Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c840acb-bf7f-4171-ac16-b55a132e1ca2"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FGInputsController1"",
            ""id"": ""85f7d4fc-cd23-43be-9e28-cc7ed857f464"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""985f85f6-cf1c-42c1-8e85-586b3275d5f3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""eb3e4177-6dfc-4a16-a7ea-ab004e5e4fff"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveJump"",
                    ""type"": ""Button"",
                    ""id"": ""6ab294bc-a33a-4724-8799-dc009e79c464"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCrouch"",
                    ""type"": ""Button"",
                    ""id"": ""29a04b28-8845-42e3-bde1-75b99345ee74"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackLight"",
                    ""type"": ""Button"",
                    ""id"": ""53224329-c4c6-442d-909b-6bab0011e32c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackMedium"",
                    ""type"": ""Button"",
                    ""id"": ""08fc93f8-ecd1-4e43-9a4f-7f456884101f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NAttackHeavy"",
                    ""type"": ""Button"",
                    ""id"": ""927b89a3-c223-4dec-94b6-72766b23d487"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Button"",
                    ""id"": ""2561bfc4-f896-4a65-bd6a-5d697253da64"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape/Menu"",
                    ""type"": ""Button"",
                    ""id"": ""4b9c36c3-1f55-4302-9127-09fecae4b396"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""17875756-0868-4398-90d3-86c892ca4540"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e36312c-ddc7-4a63-a721-fb60b4a35829"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d6cb5dc-dc91-4ace-b755-e6daf60bd69e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a1e87fe-58f1-46b6-af23-c7351e9afa74"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15956f4e-077d-4275-a97b-34789e54598a"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCrouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4456d0df-81ee-4862-bc2d-bf51dd2a160a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab54b61a-a930-46ea-bf09-49b3f54847df"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackMedium"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bafd1be-3683-4db1-addb-015de8d20b2d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NAttackHeavy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4e55ff8-485a-4b60-8580-0c709558315b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0086b939-17f1-4d48-88b5-13548f06f8b6"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape/Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd6ea9af-aec1-4477-bd2e-0d49cb47a8de"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuUIInputs"",
            ""id"": ""006fa013-2106-42db-9641-15d068afdc24"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""f14e3c8f-3df7-4dfc-a2f1-a0f212560b3d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1aed354b-7202-47db-9b3b-b33ed06b8600"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FGInputsKeyboard
        m_FGInputsKeyboard = asset.FindActionMap("FGInputsKeyboard", throwIfNotFound: true);
        m_FGInputsKeyboard_Move = m_FGInputsKeyboard.FindAction("Move", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveRight = m_FGInputsKeyboard.FindAction("MoveRight", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveLeft = m_FGInputsKeyboard.FindAction("MoveLeft", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveJump = m_FGInputsKeyboard.FindAction("MoveJump", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveCrouch = m_FGInputsKeyboard.FindAction("MoveCrouch", throwIfNotFound: true);
        m_FGInputsKeyboard_NAttackLight = m_FGInputsKeyboard.FindAction("NAttackLight", throwIfNotFound: true);
        m_FGInputsKeyboard_NAttackMedium = m_FGInputsKeyboard.FindAction("NAttackMedium", throwIfNotFound: true);
        m_FGInputsKeyboard_NAttackHeavy = m_FGInputsKeyboard.FindAction("NAttackHeavy", throwIfNotFound: true);
        m_FGInputsKeyboard_SpecialAttack = m_FGInputsKeyboard.FindAction("SpecialAttack", throwIfNotFound: true);
        m_FGInputsKeyboard_Menu = m_FGInputsKeyboard.FindAction("Menu", throwIfNotFound: true);
        m_FGInputsKeyboard_Select = m_FGInputsKeyboard.FindAction("Select", throwIfNotFound: true);
        // FGInputsKeyboard2
        m_FGInputsKeyboard2 = asset.FindActionMap("FGInputsKeyboard2", throwIfNotFound: true);
        m_FGInputsKeyboard2_Move = m_FGInputsKeyboard2.FindAction("Move", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveRight = m_FGInputsKeyboard2.FindAction("MoveRight", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveLeft = m_FGInputsKeyboard2.FindAction("MoveLeft", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveJump = m_FGInputsKeyboard2.FindAction("MoveJump", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveCrouch = m_FGInputsKeyboard2.FindAction("MoveCrouch", throwIfNotFound: true);
        m_FGInputsKeyboard2_NAttackLight = m_FGInputsKeyboard2.FindAction("NAttackLight", throwIfNotFound: true);
        m_FGInputsKeyboard2_NAttackMedium = m_FGInputsKeyboard2.FindAction("NAttackMedium", throwIfNotFound: true);
        m_FGInputsKeyboard2_NAttackHeavy = m_FGInputsKeyboard2.FindAction("NAttackHeavy", throwIfNotFound: true);
        m_FGInputsKeyboard2_SpecialAttack = m_FGInputsKeyboard2.FindAction("SpecialAttack", throwIfNotFound: true);
        m_FGInputsKeyboard2_Menu = m_FGInputsKeyboard2.FindAction("Menu", throwIfNotFound: true);
        m_FGInputsKeyboard2_Select = m_FGInputsKeyboard2.FindAction("Select", throwIfNotFound: true);
        // FGInputsController
        m_FGInputsController = asset.FindActionMap("FGInputsController", throwIfNotFound: true);
        m_FGInputsController_MoveRight = m_FGInputsController.FindAction("MoveRight", throwIfNotFound: true);
        m_FGInputsController_MoveLeft = m_FGInputsController.FindAction("MoveLeft", throwIfNotFound: true);
        m_FGInputsController_MoveJump = m_FGInputsController.FindAction("MoveJump", throwIfNotFound: true);
        m_FGInputsController_MoveCrouch = m_FGInputsController.FindAction("MoveCrouch", throwIfNotFound: true);
        m_FGInputsController_NAttackLight = m_FGInputsController.FindAction("NAttackLight", throwIfNotFound: true);
        m_FGInputsController_NAttackMedium = m_FGInputsController.FindAction("NAttackMedium", throwIfNotFound: true);
        m_FGInputsController_NAttackHeavy = m_FGInputsController.FindAction("NAttackHeavy", throwIfNotFound: true);
        m_FGInputsController_SpecialAttack = m_FGInputsController.FindAction("SpecialAttack", throwIfNotFound: true);
        m_FGInputsController_EscapeMenu = m_FGInputsController.FindAction("Escape/Menu", throwIfNotFound: true);
        m_FGInputsController_Select = m_FGInputsController.FindAction("Select", throwIfNotFound: true);
        // FGInputsController1
        m_FGInputsController1 = asset.FindActionMap("FGInputsController1", throwIfNotFound: true);
        m_FGInputsController1_MoveRight = m_FGInputsController1.FindAction("MoveRight", throwIfNotFound: true);
        m_FGInputsController1_MoveLeft = m_FGInputsController1.FindAction("MoveLeft", throwIfNotFound: true);
        m_FGInputsController1_MoveJump = m_FGInputsController1.FindAction("MoveJump", throwIfNotFound: true);
        m_FGInputsController1_MoveCrouch = m_FGInputsController1.FindAction("MoveCrouch", throwIfNotFound: true);
        m_FGInputsController1_NAttackLight = m_FGInputsController1.FindAction("NAttackLight", throwIfNotFound: true);
        m_FGInputsController1_NAttackMedium = m_FGInputsController1.FindAction("NAttackMedium", throwIfNotFound: true);
        m_FGInputsController1_NAttackHeavy = m_FGInputsController1.FindAction("NAttackHeavy", throwIfNotFound: true);
        m_FGInputsController1_SpecialAttack = m_FGInputsController1.FindAction("SpecialAttack", throwIfNotFound: true);
        m_FGInputsController1_EscapeMenu = m_FGInputsController1.FindAction("Escape/Menu", throwIfNotFound: true);
        m_FGInputsController1_Select = m_FGInputsController1.FindAction("Select", throwIfNotFound: true);
        // MenuUIInputs
        m_MenuUIInputs = asset.FindActionMap("MenuUIInputs", throwIfNotFound: true);
        m_MenuUIInputs_Newaction = m_MenuUIInputs.FindAction("New action", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // FGInputsKeyboard
    private readonly InputActionMap m_FGInputsKeyboard;
    private IFGInputsKeyboardActions m_FGInputsKeyboardActionsCallbackInterface;
    private readonly InputAction m_FGInputsKeyboard_Move;
    private readonly InputAction m_FGInputsKeyboard_MoveRight;
    private readonly InputAction m_FGInputsKeyboard_MoveLeft;
    private readonly InputAction m_FGInputsKeyboard_MoveJump;
    private readonly InputAction m_FGInputsKeyboard_MoveCrouch;
    private readonly InputAction m_FGInputsKeyboard_NAttackLight;
    private readonly InputAction m_FGInputsKeyboard_NAttackMedium;
    private readonly InputAction m_FGInputsKeyboard_NAttackHeavy;
    private readonly InputAction m_FGInputsKeyboard_SpecialAttack;
    private readonly InputAction m_FGInputsKeyboard_Menu;
    private readonly InputAction m_FGInputsKeyboard_Select;
    public struct FGInputsKeyboardActions
    {
        private @CharInputSystem m_Wrapper;
        public FGInputsKeyboardActions(@CharInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FGInputsKeyboard_Move;
        public InputAction @MoveRight => m_Wrapper.m_FGInputsKeyboard_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_FGInputsKeyboard_MoveLeft;
        public InputAction @MoveJump => m_Wrapper.m_FGInputsKeyboard_MoveJump;
        public InputAction @MoveCrouch => m_Wrapper.m_FGInputsKeyboard_MoveCrouch;
        public InputAction @NAttackLight => m_Wrapper.m_FGInputsKeyboard_NAttackLight;
        public InputAction @NAttackMedium => m_Wrapper.m_FGInputsKeyboard_NAttackMedium;
        public InputAction @NAttackHeavy => m_Wrapper.m_FGInputsKeyboard_NAttackHeavy;
        public InputAction @SpecialAttack => m_Wrapper.m_FGInputsKeyboard_SpecialAttack;
        public InputAction @Menu => m_Wrapper.m_FGInputsKeyboard_Menu;
        public InputAction @Select => m_Wrapper.m_FGInputsKeyboard_Select;
        public InputActionMap Get() { return m_Wrapper.m_FGInputsKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FGInputsKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IFGInputsKeyboardActions instance)
        {
            if (m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMove;
                @MoveRight.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveJump.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveJump;
                @MoveJump.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveJump;
                @MoveJump.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveJump;
                @MoveCrouch.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveCrouch;
                @NAttackLight.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackLight;
                @NAttackMedium.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackMedium;
                @NAttackHeavy.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnNAttackHeavy;
                @SpecialAttack.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnSpecialAttack;
                @Menu.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMenu;
                @Select.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveJump.started += instance.OnMoveJump;
                @MoveJump.performed += instance.OnMoveJump;
                @MoveJump.canceled += instance.OnMoveJump;
                @MoveCrouch.started += instance.OnMoveCrouch;
                @MoveCrouch.performed += instance.OnMoveCrouch;
                @MoveCrouch.canceled += instance.OnMoveCrouch;
                @NAttackLight.started += instance.OnNAttackLight;
                @NAttackLight.performed += instance.OnNAttackLight;
                @NAttackLight.canceled += instance.OnNAttackLight;
                @NAttackMedium.started += instance.OnNAttackMedium;
                @NAttackMedium.performed += instance.OnNAttackMedium;
                @NAttackMedium.canceled += instance.OnNAttackMedium;
                @NAttackHeavy.started += instance.OnNAttackHeavy;
                @NAttackHeavy.performed += instance.OnNAttackHeavy;
                @NAttackHeavy.canceled += instance.OnNAttackHeavy;
                @SpecialAttack.started += instance.OnSpecialAttack;
                @SpecialAttack.performed += instance.OnSpecialAttack;
                @SpecialAttack.canceled += instance.OnSpecialAttack;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public FGInputsKeyboardActions @FGInputsKeyboard => new FGInputsKeyboardActions(this);

    // FGInputsKeyboard2
    private readonly InputActionMap m_FGInputsKeyboard2;
    private IFGInputsKeyboard2Actions m_FGInputsKeyboard2ActionsCallbackInterface;
    private readonly InputAction m_FGInputsKeyboard2_Move;
    private readonly InputAction m_FGInputsKeyboard2_MoveRight;
    private readonly InputAction m_FGInputsKeyboard2_MoveLeft;
    private readonly InputAction m_FGInputsKeyboard2_MoveJump;
    private readonly InputAction m_FGInputsKeyboard2_MoveCrouch;
    private readonly InputAction m_FGInputsKeyboard2_NAttackLight;
    private readonly InputAction m_FGInputsKeyboard2_NAttackMedium;
    private readonly InputAction m_FGInputsKeyboard2_NAttackHeavy;
    private readonly InputAction m_FGInputsKeyboard2_SpecialAttack;
    private readonly InputAction m_FGInputsKeyboard2_Menu;
    private readonly InputAction m_FGInputsKeyboard2_Select;
    public struct FGInputsKeyboard2Actions
    {
        private @CharInputSystem m_Wrapper;
        public FGInputsKeyboard2Actions(@CharInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FGInputsKeyboard2_Move;
        public InputAction @MoveRight => m_Wrapper.m_FGInputsKeyboard2_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_FGInputsKeyboard2_MoveLeft;
        public InputAction @MoveJump => m_Wrapper.m_FGInputsKeyboard2_MoveJump;
        public InputAction @MoveCrouch => m_Wrapper.m_FGInputsKeyboard2_MoveCrouch;
        public InputAction @NAttackLight => m_Wrapper.m_FGInputsKeyboard2_NAttackLight;
        public InputAction @NAttackMedium => m_Wrapper.m_FGInputsKeyboard2_NAttackMedium;
        public InputAction @NAttackHeavy => m_Wrapper.m_FGInputsKeyboard2_NAttackHeavy;
        public InputAction @SpecialAttack => m_Wrapper.m_FGInputsKeyboard2_SpecialAttack;
        public InputAction @Menu => m_Wrapper.m_FGInputsKeyboard2_Menu;
        public InputAction @Select => m_Wrapper.m_FGInputsKeyboard2_Select;
        public InputActionMap Get() { return m_Wrapper.m_FGInputsKeyboard2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FGInputsKeyboard2Actions set) { return set.Get(); }
        public void SetCallbacks(IFGInputsKeyboard2Actions instance)
        {
            if (m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMove;
                @MoveRight.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveLeft;
                @MoveJump.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveJump;
                @MoveJump.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveJump;
                @MoveJump.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveJump;
                @MoveCrouch.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMoveCrouch;
                @NAttackLight.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackLight;
                @NAttackMedium.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackMedium;
                @NAttackHeavy.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnNAttackHeavy;
                @SpecialAttack.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnSpecialAttack;
                @Menu.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnMenu;
                @Select.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveJump.started += instance.OnMoveJump;
                @MoveJump.performed += instance.OnMoveJump;
                @MoveJump.canceled += instance.OnMoveJump;
                @MoveCrouch.started += instance.OnMoveCrouch;
                @MoveCrouch.performed += instance.OnMoveCrouch;
                @MoveCrouch.canceled += instance.OnMoveCrouch;
                @NAttackLight.started += instance.OnNAttackLight;
                @NAttackLight.performed += instance.OnNAttackLight;
                @NAttackLight.canceled += instance.OnNAttackLight;
                @NAttackMedium.started += instance.OnNAttackMedium;
                @NAttackMedium.performed += instance.OnNAttackMedium;
                @NAttackMedium.canceled += instance.OnNAttackMedium;
                @NAttackHeavy.started += instance.OnNAttackHeavy;
                @NAttackHeavy.performed += instance.OnNAttackHeavy;
                @NAttackHeavy.canceled += instance.OnNAttackHeavy;
                @SpecialAttack.started += instance.OnSpecialAttack;
                @SpecialAttack.performed += instance.OnSpecialAttack;
                @SpecialAttack.canceled += instance.OnSpecialAttack;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public FGInputsKeyboard2Actions @FGInputsKeyboard2 => new FGInputsKeyboard2Actions(this);

    // FGInputsController
    private readonly InputActionMap m_FGInputsController;
    private IFGInputsControllerActions m_FGInputsControllerActionsCallbackInterface;
    private readonly InputAction m_FGInputsController_MoveRight;
    private readonly InputAction m_FGInputsController_MoveLeft;
    private readonly InputAction m_FGInputsController_MoveJump;
    private readonly InputAction m_FGInputsController_MoveCrouch;
    private readonly InputAction m_FGInputsController_NAttackLight;
    private readonly InputAction m_FGInputsController_NAttackMedium;
    private readonly InputAction m_FGInputsController_NAttackHeavy;
    private readonly InputAction m_FGInputsController_SpecialAttack;
    private readonly InputAction m_FGInputsController_EscapeMenu;
    private readonly InputAction m_FGInputsController_Select;
    public struct FGInputsControllerActions
    {
        private @CharInputSystem m_Wrapper;
        public FGInputsControllerActions(@CharInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRight => m_Wrapper.m_FGInputsController_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_FGInputsController_MoveLeft;
        public InputAction @MoveJump => m_Wrapper.m_FGInputsController_MoveJump;
        public InputAction @MoveCrouch => m_Wrapper.m_FGInputsController_MoveCrouch;
        public InputAction @NAttackLight => m_Wrapper.m_FGInputsController_NAttackLight;
        public InputAction @NAttackMedium => m_Wrapper.m_FGInputsController_NAttackMedium;
        public InputAction @NAttackHeavy => m_Wrapper.m_FGInputsController_NAttackHeavy;
        public InputAction @SpecialAttack => m_Wrapper.m_FGInputsController_SpecialAttack;
        public InputAction @EscapeMenu => m_Wrapper.m_FGInputsController_EscapeMenu;
        public InputAction @Select => m_Wrapper.m_FGInputsController_Select;
        public InputActionMap Get() { return m_Wrapper.m_FGInputsController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FGInputsControllerActions set) { return set.Get(); }
        public void SetCallbacks(IFGInputsControllerActions instance)
        {
            if (m_Wrapper.m_FGInputsControllerActionsCallbackInterface != null)
            {
                @MoveRight.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveLeft;
                @MoveJump.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveJump;
                @MoveJump.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveJump;
                @MoveJump.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveJump;
                @MoveCrouch.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnMoveCrouch;
                @NAttackLight.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackLight;
                @NAttackMedium.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackMedium;
                @NAttackHeavy.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnNAttackHeavy;
                @SpecialAttack.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnSpecialAttack;
                @EscapeMenu.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnEscapeMenu;
                @EscapeMenu.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnEscapeMenu;
                @EscapeMenu.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnEscapeMenu;
                @Select.started -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_FGInputsControllerActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_FGInputsControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveJump.started += instance.OnMoveJump;
                @MoveJump.performed += instance.OnMoveJump;
                @MoveJump.canceled += instance.OnMoveJump;
                @MoveCrouch.started += instance.OnMoveCrouch;
                @MoveCrouch.performed += instance.OnMoveCrouch;
                @MoveCrouch.canceled += instance.OnMoveCrouch;
                @NAttackLight.started += instance.OnNAttackLight;
                @NAttackLight.performed += instance.OnNAttackLight;
                @NAttackLight.canceled += instance.OnNAttackLight;
                @NAttackMedium.started += instance.OnNAttackMedium;
                @NAttackMedium.performed += instance.OnNAttackMedium;
                @NAttackMedium.canceled += instance.OnNAttackMedium;
                @NAttackHeavy.started += instance.OnNAttackHeavy;
                @NAttackHeavy.performed += instance.OnNAttackHeavy;
                @NAttackHeavy.canceled += instance.OnNAttackHeavy;
                @SpecialAttack.started += instance.OnSpecialAttack;
                @SpecialAttack.performed += instance.OnSpecialAttack;
                @SpecialAttack.canceled += instance.OnSpecialAttack;
                @EscapeMenu.started += instance.OnEscapeMenu;
                @EscapeMenu.performed += instance.OnEscapeMenu;
                @EscapeMenu.canceled += instance.OnEscapeMenu;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public FGInputsControllerActions @FGInputsController => new FGInputsControllerActions(this);

    // FGInputsController1
    private readonly InputActionMap m_FGInputsController1;
    private IFGInputsController1Actions m_FGInputsController1ActionsCallbackInterface;
    private readonly InputAction m_FGInputsController1_MoveRight;
    private readonly InputAction m_FGInputsController1_MoveLeft;
    private readonly InputAction m_FGInputsController1_MoveJump;
    private readonly InputAction m_FGInputsController1_MoveCrouch;
    private readonly InputAction m_FGInputsController1_NAttackLight;
    private readonly InputAction m_FGInputsController1_NAttackMedium;
    private readonly InputAction m_FGInputsController1_NAttackHeavy;
    private readonly InputAction m_FGInputsController1_SpecialAttack;
    private readonly InputAction m_FGInputsController1_EscapeMenu;
    private readonly InputAction m_FGInputsController1_Select;
    public struct FGInputsController1Actions
    {
        private @CharInputSystem m_Wrapper;
        public FGInputsController1Actions(@CharInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRight => m_Wrapper.m_FGInputsController1_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_FGInputsController1_MoveLeft;
        public InputAction @MoveJump => m_Wrapper.m_FGInputsController1_MoveJump;
        public InputAction @MoveCrouch => m_Wrapper.m_FGInputsController1_MoveCrouch;
        public InputAction @NAttackLight => m_Wrapper.m_FGInputsController1_NAttackLight;
        public InputAction @NAttackMedium => m_Wrapper.m_FGInputsController1_NAttackMedium;
        public InputAction @NAttackHeavy => m_Wrapper.m_FGInputsController1_NAttackHeavy;
        public InputAction @SpecialAttack => m_Wrapper.m_FGInputsController1_SpecialAttack;
        public InputAction @EscapeMenu => m_Wrapper.m_FGInputsController1_EscapeMenu;
        public InputAction @Select => m_Wrapper.m_FGInputsController1_Select;
        public InputActionMap Get() { return m_Wrapper.m_FGInputsController1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FGInputsController1Actions set) { return set.Get(); }
        public void SetCallbacks(IFGInputsController1Actions instance)
        {
            if (m_Wrapper.m_FGInputsController1ActionsCallbackInterface != null)
            {
                @MoveRight.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveLeft;
                @MoveJump.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveJump;
                @MoveJump.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveJump;
                @MoveJump.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveJump;
                @MoveCrouch.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveCrouch;
                @MoveCrouch.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnMoveCrouch;
                @NAttackLight.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackLight;
                @NAttackLight.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackLight;
                @NAttackMedium.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackMedium;
                @NAttackMedium.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackMedium;
                @NAttackHeavy.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackHeavy;
                @NAttackHeavy.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnNAttackHeavy;
                @SpecialAttack.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnSpecialAttack;
                @EscapeMenu.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnEscapeMenu;
                @EscapeMenu.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnEscapeMenu;
                @EscapeMenu.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnEscapeMenu;
                @Select.started -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_FGInputsController1ActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_FGInputsController1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveJump.started += instance.OnMoveJump;
                @MoveJump.performed += instance.OnMoveJump;
                @MoveJump.canceled += instance.OnMoveJump;
                @MoveCrouch.started += instance.OnMoveCrouch;
                @MoveCrouch.performed += instance.OnMoveCrouch;
                @MoveCrouch.canceled += instance.OnMoveCrouch;
                @NAttackLight.started += instance.OnNAttackLight;
                @NAttackLight.performed += instance.OnNAttackLight;
                @NAttackLight.canceled += instance.OnNAttackLight;
                @NAttackMedium.started += instance.OnNAttackMedium;
                @NAttackMedium.performed += instance.OnNAttackMedium;
                @NAttackMedium.canceled += instance.OnNAttackMedium;
                @NAttackHeavy.started += instance.OnNAttackHeavy;
                @NAttackHeavy.performed += instance.OnNAttackHeavy;
                @NAttackHeavy.canceled += instance.OnNAttackHeavy;
                @SpecialAttack.started += instance.OnSpecialAttack;
                @SpecialAttack.performed += instance.OnSpecialAttack;
                @SpecialAttack.canceled += instance.OnSpecialAttack;
                @EscapeMenu.started += instance.OnEscapeMenu;
                @EscapeMenu.performed += instance.OnEscapeMenu;
                @EscapeMenu.canceled += instance.OnEscapeMenu;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public FGInputsController1Actions @FGInputsController1 => new FGInputsController1Actions(this);

    // MenuUIInputs
    private readonly InputActionMap m_MenuUIInputs;
    private IMenuUIInputsActions m_MenuUIInputsActionsCallbackInterface;
    private readonly InputAction m_MenuUIInputs_Newaction;
    public struct MenuUIInputsActions
    {
        private @CharInputSystem m_Wrapper;
        public MenuUIInputsActions(@CharInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_MenuUIInputs_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_MenuUIInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuUIInputsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuUIInputsActions instance)
        {
            if (m_Wrapper.m_MenuUIInputsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuUIInputsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuUIInputsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuUIInputsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuUIInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuUIInputsActions @MenuUIInputs => new MenuUIInputsActions(this);
    public interface IFGInputsKeyboardActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveJump(InputAction.CallbackContext context);
        void OnMoveCrouch(InputAction.CallbackContext context);
        void OnNAttackLight(InputAction.CallbackContext context);
        void OnNAttackMedium(InputAction.CallbackContext context);
        void OnNAttackHeavy(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IFGInputsKeyboard2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveJump(InputAction.CallbackContext context);
        void OnMoveCrouch(InputAction.CallbackContext context);
        void OnNAttackLight(InputAction.CallbackContext context);
        void OnNAttackMedium(InputAction.CallbackContext context);
        void OnNAttackHeavy(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IFGInputsControllerActions
    {
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveJump(InputAction.CallbackContext context);
        void OnMoveCrouch(InputAction.CallbackContext context);
        void OnNAttackLight(InputAction.CallbackContext context);
        void OnNAttackMedium(InputAction.CallbackContext context);
        void OnNAttackHeavy(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
        void OnEscapeMenu(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IFGInputsController1Actions
    {
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveJump(InputAction.CallbackContext context);
        void OnMoveCrouch(InputAction.CallbackContext context);
        void OnNAttackLight(InputAction.CallbackContext context);
        void OnNAttackMedium(InputAction.CallbackContext context);
        void OnNAttackHeavy(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
        void OnEscapeMenu(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IMenuUIInputsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
