// GENERATED AUTOMATICALLY FROM 'Assets/CharInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
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
                    ""name"": ""DashRight"",
                    ""type"": ""Button"",
                    ""id"": ""0fd3956d-418b-4eb2-8905-ce1d96493b5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DashLeft"",
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
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""de2c2203-ac32-4a6b-acdb-7c010e5db29a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""06d767ea-a3ff-4f6a-84ac-c17d725774d3"",
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
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea88242b-321d-4dfe-9eb0-121b32633d8a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashLeft"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""974a6199-a086-49d8-ac65-5835ecf3e4d7"",
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
                    ""id"": ""32d297f3-34ac-45ba-935a-590b3ce10a3c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                    ""name"": ""DashLeft"",
                    ""type"": ""Button"",
                    ""id"": ""14ddf37d-7f90-40fe-8b25-393b4bb09c5e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DashRight"",
                    ""type"": ""Button"",
                    ""id"": ""e80be93d-0c28-482b-8800-6f80ee7086ef"",
                    ""expectedControlType"": ""Button"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""6ccac890-ac67-4110-8124-3e1a5d6008ae"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b7668b6-021c-4e81-bb1b-45f8ca1fce46"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
            ""name"": ""MenuControls"",
            ""id"": ""006fa013-2106-42db-9641-15d068afdc24"",
            ""actions"": [
                {
                    ""name"": ""TrackedDeviceSelect"",
                    ""type"": ""PassThrough"",
                    ""id"": ""23bd5456-c2eb-401c-93f8-04c6ae6fc1e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0a836362-c04b-4e3a-9466-59a4be2a7821"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""caeaabaa-8a17-402e-b357-5dd23e8a6ef3"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9aae43df-ca97-48e7-b640-595587888bc7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""189c375f-b5b9-434d-8c16-faf28e24c8aa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""880f535f-ca0d-4aa0-8935-372c8fed7a0d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""66c23a71-f6b1-46a0-bb78-95addf574ef2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""29704136-baaa-429b-af57-20d5676c0005"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""60caef70-b573-4040-8040-be3875eff30c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""57005224-ad8c-4f4a-a603-a1e3cc01a1b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""37a6a98d-00cd-4c10-9725-73d96ba20559"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""fc7dd661-78cf-4eec-8f7a-8bcefbae9294"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1b4e7997-d1d2-406f-8830-fdbc877ddc5d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""86e798c4-e7ba-46d8-bdb3-fc5e8a57d3d7"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f6b41050-e5d3-4446-8cb3-183273b3517b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""738faf7c-1ed1-4542-bfff-4109f8c43d1c"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7266dac0-ccf3-4256-b424-a7a2e1caf383"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3349c7f8-05cc-40c7-ae6b-10230406581f"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""69fac0e8-09a0-42e7-87d7-ea73c7bad608"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""80544160-36d0-4a5e-8875-c14e33168c21"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d815221b-0d05-411f-a978-ef903f3a4425"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""db16082d-ee78-4c8f-8c60-27e9857b83cd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""357f2d02-b14b-4c78-8229-dabf5f6a1a6f"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3229dc59-f112-4373-845f-cd412ebc345c"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dfb28ee2-121b-438c-b007-79b66fe498c9"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4aa877a7-75fd-4fb5-878e-779b37f1a9a9"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""5802e03e-c816-46a0-9d78-507ebeb42ed1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c0f4d918-8a31-4416-8f80-766f2a640395"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""84b2d1ff-7792-46a0-860f-9431a3ea1b88"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f09e46d-ca8e-4299-b7cd-e9e014515bb9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""57d6990a-ecb0-48fa-b7e4-3b72439a72b6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""750f2089-be1d-46b7-b08f-fce8e0c3f13a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4825b099-1a34-430e-9922-fbf3495f7a35"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bb3ece0b-beef-483f-8268-7150559de4c6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""54146760-897c-4ac8-b9df-2464fcb42ad5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d8ee84c9-4fa4-44f0-bd07-082511266c0f"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d64e7a2-d0d7-46ec-a00f-a0fa0c3cc788"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f735148-cc1f-4d62-872b-c339e18a634b"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ee4f188-5883-4a63-a5c4-feadd7e1ea23"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6dc2bbc4-eebf-4a6e-8606-9c1a1c21510d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15fbe92d-ab9d-4d50-9507-00450f045b74"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d3dcb31-9433-49ed-b261-5f864d3cc5d6"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""708be68a-0845-4ccf-83da-5a800149637c"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e656c3b6-5b14-4a65-a58d-6b8f4b3965cb"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a89d27f7-e5bc-49ab-b92a-7fbcb1ac110e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""176df096-bf82-4fd0-a825-b7b3b8636bc4"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ecf70013-43cd-4a77-b6a7-acf033d5e6ae"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57da8299-ec14-47f0-a694-8aaf540a2460"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceSelect"",
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
        m_FGInputsKeyboard_DashRight = m_FGInputsKeyboard.FindAction("DashRight", throwIfNotFound: true);
        m_FGInputsKeyboard_DashLeft = m_FGInputsKeyboard.FindAction("DashLeft", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveJump = m_FGInputsKeyboard.FindAction("MoveJump", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveCrouch = m_FGInputsKeyboard.FindAction("MoveCrouch", throwIfNotFound: true);
        m_FGInputsKeyboard_NAttackLight = m_FGInputsKeyboard.FindAction("NAttackLight", throwIfNotFound: true);
        m_FGInputsKeyboard_NAttackMedium = m_FGInputsKeyboard.FindAction("NAttackMedium", throwIfNotFound: true);
        m_FGInputsKeyboard_NAttackHeavy = m_FGInputsKeyboard.FindAction("NAttackHeavy", throwIfNotFound: true);
        m_FGInputsKeyboard_SpecialAttack = m_FGInputsKeyboard.FindAction("SpecialAttack", throwIfNotFound: true);
        m_FGInputsKeyboard_Menu = m_FGInputsKeyboard.FindAction("Menu", throwIfNotFound: true);
        m_FGInputsKeyboard_Select = m_FGInputsKeyboard.FindAction("Select", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveRight = m_FGInputsKeyboard.FindAction("MoveRight", throwIfNotFound: true);
        m_FGInputsKeyboard_MoveLeft = m_FGInputsKeyboard.FindAction("MoveLeft", throwIfNotFound: true);
        // FGInputsKeyboard2
        m_FGInputsKeyboard2 = asset.FindActionMap("FGInputsKeyboard2", throwIfNotFound: true);
        m_FGInputsKeyboard2_Move = m_FGInputsKeyboard2.FindAction("Move", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveRight = m_FGInputsKeyboard2.FindAction("MoveRight", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveLeft = m_FGInputsKeyboard2.FindAction("MoveLeft", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveJump = m_FGInputsKeyboard2.FindAction("MoveJump", throwIfNotFound: true);
        m_FGInputsKeyboard2_MoveCrouch = m_FGInputsKeyboard2.FindAction("MoveCrouch", throwIfNotFound: true);
        m_FGInputsKeyboard2_DashLeft = m_FGInputsKeyboard2.FindAction("DashLeft", throwIfNotFound: true);
        m_FGInputsKeyboard2_DashRight = m_FGInputsKeyboard2.FindAction("DashRight", throwIfNotFound: true);
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
        // MenuControls
        m_MenuControls = asset.FindActionMap("MenuControls", throwIfNotFound: true);
        m_MenuControls_TrackedDeviceSelect = m_MenuControls.FindAction("TrackedDeviceSelect", throwIfNotFound: true);
        m_MenuControls_TrackedDeviceOrientation = m_MenuControls.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        m_MenuControls_TrackedDevicePosition = m_MenuControls.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_MenuControls_RightClick = m_MenuControls.FindAction("RightClick", throwIfNotFound: true);
        m_MenuControls_MiddleClick = m_MenuControls.FindAction("MiddleClick", throwIfNotFound: true);
        m_MenuControls_ScrollWheel = m_MenuControls.FindAction("ScrollWheel", throwIfNotFound: true);
        m_MenuControls_Click = m_MenuControls.FindAction("Click", throwIfNotFound: true);
        m_MenuControls_Point = m_MenuControls.FindAction("Point", throwIfNotFound: true);
        m_MenuControls_Cancel = m_MenuControls.FindAction("Cancel", throwIfNotFound: true);
        m_MenuControls_Submit = m_MenuControls.FindAction("Submit", throwIfNotFound: true);
        m_MenuControls_Navigate = m_MenuControls.FindAction("Navigate", throwIfNotFound: true);
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
    private readonly InputAction m_FGInputsKeyboard_DashRight;
    private readonly InputAction m_FGInputsKeyboard_DashLeft;
    private readonly InputAction m_FGInputsKeyboard_MoveJump;
    private readonly InputAction m_FGInputsKeyboard_MoveCrouch;
    private readonly InputAction m_FGInputsKeyboard_NAttackLight;
    private readonly InputAction m_FGInputsKeyboard_NAttackMedium;
    private readonly InputAction m_FGInputsKeyboard_NAttackHeavy;
    private readonly InputAction m_FGInputsKeyboard_SpecialAttack;
    private readonly InputAction m_FGInputsKeyboard_Menu;
    private readonly InputAction m_FGInputsKeyboard_Select;
    private readonly InputAction m_FGInputsKeyboard_MoveRight;
    private readonly InputAction m_FGInputsKeyboard_MoveLeft;
    public struct FGInputsKeyboardActions
    {
        private @CharInputSystem m_Wrapper;
        public FGInputsKeyboardActions(@CharInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FGInputsKeyboard_Move;
        public InputAction @DashRight => m_Wrapper.m_FGInputsKeyboard_DashRight;
        public InputAction @DashLeft => m_Wrapper.m_FGInputsKeyboard_DashLeft;
        public InputAction @MoveJump => m_Wrapper.m_FGInputsKeyboard_MoveJump;
        public InputAction @MoveCrouch => m_Wrapper.m_FGInputsKeyboard_MoveCrouch;
        public InputAction @NAttackLight => m_Wrapper.m_FGInputsKeyboard_NAttackLight;
        public InputAction @NAttackMedium => m_Wrapper.m_FGInputsKeyboard_NAttackMedium;
        public InputAction @NAttackHeavy => m_Wrapper.m_FGInputsKeyboard_NAttackHeavy;
        public InputAction @SpecialAttack => m_Wrapper.m_FGInputsKeyboard_SpecialAttack;
        public InputAction @Menu => m_Wrapper.m_FGInputsKeyboard_Menu;
        public InputAction @Select => m_Wrapper.m_FGInputsKeyboard_Select;
        public InputAction @MoveRight => m_Wrapper.m_FGInputsKeyboard_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_FGInputsKeyboard_MoveLeft;
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
                @DashRight.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnDashRight;
                @DashRight.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnDashRight;
                @DashRight.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnDashRight;
                @DashLeft.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnDashLeft;
                @DashLeft.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnDashLeft;
                @DashLeft.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnDashLeft;
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
                @MoveRight.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface.OnMoveLeft;
            }
            m_Wrapper.m_FGInputsKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @DashRight.started += instance.OnDashRight;
                @DashRight.performed += instance.OnDashRight;
                @DashRight.canceled += instance.OnDashRight;
                @DashLeft.started += instance.OnDashLeft;
                @DashLeft.performed += instance.OnDashLeft;
                @DashLeft.canceled += instance.OnDashLeft;
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
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
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
    private readonly InputAction m_FGInputsKeyboard2_DashLeft;
    private readonly InputAction m_FGInputsKeyboard2_DashRight;
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
        public InputAction @DashLeft => m_Wrapper.m_FGInputsKeyboard2_DashLeft;
        public InputAction @DashRight => m_Wrapper.m_FGInputsKeyboard2_DashRight;
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
                @DashLeft.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnDashLeft;
                @DashLeft.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnDashLeft;
                @DashLeft.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnDashLeft;
                @DashRight.started -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnDashRight;
                @DashRight.performed -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnDashRight;
                @DashRight.canceled -= m_Wrapper.m_FGInputsKeyboard2ActionsCallbackInterface.OnDashRight;
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
                @DashLeft.started += instance.OnDashLeft;
                @DashLeft.performed += instance.OnDashLeft;
                @DashLeft.canceled += instance.OnDashLeft;
                @DashRight.started += instance.OnDashRight;
                @DashRight.performed += instance.OnDashRight;
                @DashRight.canceled += instance.OnDashRight;
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

    // MenuControls
    private readonly InputActionMap m_MenuControls;
    private IMenuControlsActions m_MenuControlsActionsCallbackInterface;
    private readonly InputAction m_MenuControls_TrackedDeviceSelect;
    private readonly InputAction m_MenuControls_TrackedDeviceOrientation;
    private readonly InputAction m_MenuControls_TrackedDevicePosition;
    private readonly InputAction m_MenuControls_RightClick;
    private readonly InputAction m_MenuControls_MiddleClick;
    private readonly InputAction m_MenuControls_ScrollWheel;
    private readonly InputAction m_MenuControls_Click;
    private readonly InputAction m_MenuControls_Point;
    private readonly InputAction m_MenuControls_Cancel;
    private readonly InputAction m_MenuControls_Submit;
    private readonly InputAction m_MenuControls_Navigate;
    public struct MenuControlsActions
    {
        private @CharInputSystem m_Wrapper;
        public MenuControlsActions(@CharInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @TrackedDeviceSelect => m_Wrapper.m_MenuControls_TrackedDeviceSelect;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_MenuControls_TrackedDeviceOrientation;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_MenuControls_TrackedDevicePosition;
        public InputAction @RightClick => m_Wrapper.m_MenuControls_RightClick;
        public InputAction @MiddleClick => m_Wrapper.m_MenuControls_MiddleClick;
        public InputAction @ScrollWheel => m_Wrapper.m_MenuControls_ScrollWheel;
        public InputAction @Click => m_Wrapper.m_MenuControls_Click;
        public InputAction @Point => m_Wrapper.m_MenuControls_Point;
        public InputAction @Cancel => m_Wrapper.m_MenuControls_Cancel;
        public InputAction @Submit => m_Wrapper.m_MenuControls_Submit;
        public InputAction @Navigate => m_Wrapper.m_MenuControls_Navigate;
        public InputActionMap Get() { return m_Wrapper.m_MenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlsActions instance)
        {
            if (m_Wrapper.m_MenuControlsActionsCallbackInterface != null)
            {
                @TrackedDeviceSelect.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceSelect;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDevicePosition.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @RightClick.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @MiddleClick.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @ScrollWheel.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @Click.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Point.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Cancel.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Submit.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Navigate.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
            }
            m_Wrapper.m_MenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TrackedDeviceSelect.started += instance.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.performed += instance.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.canceled += instance.OnTrackedDeviceSelect;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
            }
        }
    }
    public MenuControlsActions @MenuControls => new MenuControlsActions(this);
    public interface IFGInputsKeyboardActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDashRight(InputAction.CallbackContext context);
        void OnDashLeft(InputAction.CallbackContext context);
        void OnMoveJump(InputAction.CallbackContext context);
        void OnMoveCrouch(InputAction.CallbackContext context);
        void OnNAttackLight(InputAction.CallbackContext context);
        void OnNAttackMedium(InputAction.CallbackContext context);
        void OnNAttackHeavy(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
    }
    public interface IFGInputsKeyboard2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveJump(InputAction.CallbackContext context);
        void OnMoveCrouch(InputAction.CallbackContext context);
        void OnDashLeft(InputAction.CallbackContext context);
        void OnDashRight(InputAction.CallbackContext context);
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
    public interface IMenuControlsActions
    {
        void OnTrackedDeviceSelect(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
    }
}
