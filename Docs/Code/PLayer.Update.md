```csharp
	public void Update(int i)
	{
		// Auto-disposed at the end of the method.
		using var _currentPlr = new Main.CurrentPlayerOverride(this);

		if (i == Main.myPlayer && Main.netMode != 2)
			LockOnHelper.Update();

		if (i == Main.myPlayer && Main.dontStarveWorld)
			DontStarveDarknessDamageDealer.Update(this);

		maxFallSpeed = 10f;
		gravity = defaultGravity;
		jumpHeight = 15;
		jumpSpeed = 5.01f;
		maxRunSpeed = 3f;
		runAcceleration = 0.08f;
		runSlowdown = 0.2f;
		accRunSpeed = maxRunSpeed;
		if (!mount.Active || !mount.Cart)
			onWrongGround = false;

		heldProj = -1;
		instantMovementAccumulatedThisFrame = Vector2.Zero;
		if (PortalPhysicsEnabled)
			maxFallSpeed = 35f;

		if (shimmerWet || shimmering) {
			if (shimmering) {
				gravity *= 0.9f;
				maxFallSpeed *= 0.9f;
			}
			else {
				gravity = 0.15f;
				jumpHeight = 23;
				jumpSpeed = 5.51f;
			}
		}
		else if (wet) {
			if (honeyWet) {
				gravity = 0.1f;
				maxFallSpeed = 3f;
			}
			else if (merman) {
				gravity = 0.3f;
				maxFallSpeed = 7f;
			}
			else if (trident && !lavaWet) {
				gravity = 0.25f;
				maxFallSpeed = 6f;
				jumpHeight = 25;
				jumpSpeed = 5.51f;
				if (controlUp) {
					gravity = 0.1f;
					maxFallSpeed = 2f;
				}
			}
			else {
				gravity = 0.2f;
				maxFallSpeed = 5f;
				jumpHeight = 30;
				jumpSpeed = 6.01f;
			}
		}

		if (vortexDebuff)
			gravity = 0f;

		maxFallSpeed += 0.01f;
		bool flag = false;
		if (Main.myPlayer == i) {
			if (Main.mapFullscreen)
				GamepadEnableGrappleCooldown();
			else if (_quickGrappleCooldown > 0)
				_quickGrappleCooldown--;

			TileObject.objectPreview.Reset();
			if (DD2Event.DownedInvasionAnyDifficulty)
				downedDD2EventAnyDifficulty = true;

			autoReuseAllWeapons = Main.SettingsEnabled_AutoReuseAllItems;
		}

		if (NPC.freeCake && talkNPC >= 0 && Main.npc[talkNPC].type == 208) {
			NPC.freeCake = false;
			if (Main.netMode != 1)
				Item.NewItem(new EntitySource_Gift(Main.npc[talkNPC]), (int)position.X, (int)position.Y, width, height, 3750);
		}

		if (emoteTime > 0)
			emoteTime--;

		if (ghostDmg > 0f)
			ghostDmg -= 6.6666665f;

		if (ghostDmg < 0f)
			ghostDmg = 0f;

		if (Main.expertMode) {
			if (lifeSteal < 70f)
				lifeSteal += 0.5f;

			if (lifeSteal > 70f)
				lifeSteal = 70f;
		}
		else {
			if (lifeSteal < 80f)
				lifeSteal += 0.6f;

			if (lifeSteal > 80f)
				lifeSteal = 80f;
		}

		ResizeHitbox();
		if (mount.Active && mount.Type == 0) {
			int num = (int)(position.X + (float)(width / 2)) / 16;
			int j = (int)(position.Y + (float)(height / 2) - 14f) / 16;
			Lighting.AddLight(num, j, 0.5f, 0.2f, 0.05f);
			Lighting.AddLight(num + direction, j, 0.5f, 0.2f, 0.05f);
			Lighting.AddLight(num + direction * 2, j, 0.5f, 0.2f, 0.05f);
		}

		outOfRange = false;
		if (whoAmI != Main.myPlayer) {
			int num2 = (int)(position.X + (float)(width / 2)) / 16;
			int num3 = (int)(position.Y + (float)(height / 2)) / 16;
			/*
			if (!WorldGen.InWorld(num2, num3, 4))
				flag = true;
			else if (Main.tile[num2, num3] == null)
				flag = true;
			else if (Main.tile[num2 - 3, num3] == null)
				flag = true;
			else if (Main.tile[num2 + 3, num3] == null)
				flag = true;
			else if (Main.tile[num2, num3 - 3] == null)
				flag = true;
			else if (Main.tile[num2, num3 + 3] == null)
				flag = true;
			*/
			if (Main.netMode == 1 && !Main.sectionManager.TilesLoaded(num2 - 3, num3 - 3, num2 + 3, num3 + 3))
				flag = true;

			if (flag) {
				outOfRange = true;
				numMinions = 0;
				slotsMinions = 0f;
				itemAnimation = 0;
				UpdateBuffs(i);
				PlayerFrame();
			}
		}

		if (tankPet >= 0) {
			if (!tankPetReset)
				tankPetReset = true;
			else
				tankPet = -1;
		}

		if (i == Main.myPlayer)
			IsVoidVaultEnabled = HasItem(4131);

		if (chatOverhead.timeLeft > 0)
			chatOverhead.timeLeft--;

		if (snowBallLauncherInteractionCooldown > 0)
			snowBallLauncherInteractionCooldown--;

		environmentBuffImmunityTimer = Math.Max(0, environmentBuffImmunityTimer - 1);
		if (flag)
			return;

		UpdateHairDyeDust();
		UpdateMiscCounter();

		PlayerLoader.PreUpdate(this);

		infernoCounter++;
		if (infernoCounter >= 180)
			infernoCounter = 0;

		timeSinceLastDashStarted++;
		if (timeSinceLastDashStarted >= 300)
			timeSinceLastDashStarted = 300;

		_framesLeftEligibleForDeadmansChestDeathAchievement--;
		if (_framesLeftEligibleForDeadmansChestDeathAchievement < 0)
			_framesLeftEligibleForDeadmansChestDeathAchievement = 0;

		if (titaniumStormCooldown > 0)
			titaniumStormCooldown--;

		if (starCloakCooldown > 0) {
			starCloakCooldown--;
			if (Main.rand.Next(5) == 0) {
				for (int k = 0; k < 2; k++) {
					Dust dust = Dust.NewDustDirect(position, width, height, 45, 0f, 0f, 255, default(Color), (float)Main.rand.Next(20, 26) * 0.1f);
					dust.noLight = true;
					dust.noGravity = true;
					dust.velocity *= 0.5f;
					dust.velocity.X = 0f;
					dust.velocity.Y -= 0.5f;
				}
			}

			if (starCloakCooldown == 0)
				SoundEngine.PlaySound(25);
		}

		_timeSinceLastImmuneGet++;
		if (_timeSinceLastImmuneGet >= 10000)
			_timeSinceLastImmuneGet = 10000;

		float num4 = (float)Main.maxTilesX / 4200f;
		num4 *= num4;
		float num5 = (float)((double)(position.Y / 16f - (60f + 10f * num4)) / (Main.worldSurface / 6.0));
		if (Main.remixWorld)
			num5 = (float)((double)(position.Y / 16f - (60f + 10f * num4)) / (Main.worldSurface / 1.0));

		if (Main.remixWorld) {
			if ((double)num5 < 0.1)
				num5 = 0.1f;
		}
		else if ((double)num5 < 0.25) {
			num5 = 0.25f;
		}

		if (num5 > 1f)
			num5 = 1f;

		gravity *= num5;
		maxRegenDelay = (1f - (float)statMana / (float)statManaMax2) * 60f * 4f + 45f;
		maxRegenDelay *= 0.7f;
		UpdateSocialShadow();
		UpdateTeleportVisuals();
		whoAmI = i;
		if (whoAmI == Main.myPlayer) {
			if (!DD2Event.Ongoing)
				PurgeDD2EnergyCrystals();

			TryPortalJumping();
			if (whoAmI == Main.myPlayer)
				doorHelper.Update(this);
		}

		if (runSoundDelay > 0)
			runSoundDelay--;

		if (attackCD > 0)
			attackCD--;

		if (itemAnimation == 0)
			attackCD = 0;

		if (potionDelay > 0)
			potionDelay--;

		if (i == Main.myPlayer) {
			if (trashItem.type >= 1522 && trashItem.type <= 1527)
				trashItem.SetDefaults();

			if (trashItem.type == 3643)
				trashItem.SetDefaults();

			UpdateBiomes();
			UpdateMinionTarget();
		}

		if (ghost) {
			Ghost();
			return;
		}

		if (dead) {
			UpdateDead();
			ResetProjectileCaches();
			UpdateProjectileCaches(i);
			return;
		}

		TrySpawningFaelings();
		if (i == Main.myPlayer && hasLucyTheAxe)
			LucyAxeMessage.TryPlayingIdleMessage();

		if (velocity.Y == 0f)
			mount.FatigueRecovery();

		if (i == Main.myPlayer && !isControlledByFilm) {
			ResetControls();
			if (Main.hasFocus) {
				if (!Main.drawingPlayerChat && !Main.editSign && !Main.editChest && !Main.blockInput) {
					PlayerInput.Triggers.Current.CopyInto(this);
					LocalInputCache = new DirectionalInputSyncCache(this);
					if (Main.mapFullscreen) {
						if (controlUp)
							Main.mapFullscreenPos.Y -= 1f * (16f / Main.mapFullscreenScale);

						if (controlDown)
							Main.mapFullscreenPos.Y += 1f * (16f / Main.mapFullscreenScale);

						if (controlLeft)
							Main.mapFullscreenPos.X -= 1f * (16f / Main.mapFullscreenScale);

						if (controlRight)
							Main.mapFullscreenPos.X += 1f * (16f / Main.mapFullscreenScale);

						controlUp = false;
						controlLeft = false;
						controlDown = false;
						controlRight = false;
						controlJump = false;
						controlUseItem = false;
						controlUseTile = false;
						controlThrow = false;
						controlHook = false;
						controlTorch = false;
						controlSmart = false;
						controlMount = false;
					}

					if (isOperatingAnotherEntity)
						controlUp = (controlDown = (controlLeft = (controlRight = (controlJump = false))));

					if (controlQuickHeal) {
						if (releaseQuickHeal)
							QuickHeal();

						releaseQuickHeal = false;
					}
					else {
						releaseQuickHeal = true;
					}

					if (controlQuickMana) {
						if (releaseQuickMana)
							QuickMana();

						releaseQuickMana = false;
					}
					else {
						releaseQuickMana = true;
					}

					if (controlCreativeMenu) {
						if (releaseCreativeMenu)
							ToggleCreativeMenu();

						releaseCreativeMenu = false;
					}
					else {
						releaseCreativeMenu = true;
					}

					if (controlLeft && controlRight) {
						controlLeft = false;
						controlRight = false;
					}

					if (PlayerInput.UsingGamepad || !mouseInterface || !ItemSlot.Options.DisableLeftShiftTrashCan) {
						if (PlayerInput.SteamDeckIsUsed && PlayerInput.SettingsForUI.CurrentCursorMode == CursorMode.Mouse)
							TryToToggleSmartCursor(ref Main.SmartCursorWanted_Mouse);
						else if (PlayerInput.UsingGamepad)
							TryToToggleSmartCursor(ref Main.SmartCursorWanted_GamePad);
						else
							TryToToggleSmartCursor(ref Main.SmartCursorWanted_Mouse);
					}

					if (controlSmart)
						releaseSmart = false;
					else
						releaseSmart = true;

					if (controlMount) {
						if (releaseMount)
							QuickMount();

						releaseMount = false;
					}
					else {
						releaseMount = true;
					}

					if (Main.mapFullscreen) {
						if (mapZoomIn)
							Main.mapFullscreenScale *= 1.05f;

						if (mapZoomOut)
							Main.mapFullscreenScale *= 0.95f;
					}
					else {
						if (Main.mapStyle == 1) {
							if (mapZoomIn)
								Main.mapMinimapScale *= 1.025f;

							if (mapZoomOut)
								Main.mapMinimapScale *= 0.975f;

							if (mapAlphaUp)
								Main.mapMinimapAlpha += 0.015f;

							if (mapAlphaDown)
								Main.mapMinimapAlpha -= 0.015f;
						}
						else if (Main.mapStyle == 2) {
							if (mapZoomIn)
								Main.mapOverlayScale *= 1.05f;

							if (mapZoomOut)
								Main.mapOverlayScale *= 0.95f;

							if (mapAlphaUp)
								Main.mapOverlayAlpha += 0.015f;

							if (mapAlphaDown)
								Main.mapOverlayAlpha -= 0.015f;
						}

						if (mapStyle) {
							if (releaseMapStyle) {
								SoundEngine.PlaySound(12);
								Main.mapStyle++;
								if (Main.mapStyle > 2)
									Main.mapStyle = 0;
							}

							releaseMapStyle = false;
						}
						else {
							releaseMapStyle = true;
						}
					}

					if (mapFullScreen) {
						if (releaseMapFullscreen) {
							if (Main.mapFullscreen) {
								SoundEngine.PlaySound(11);
								Main.mapFullscreen = false;
							}
							else {
								TryOpeningFullscreenMap();
							}
						}

						releaseMapFullscreen = false;
					}
					else {
						releaseMapFullscreen = true;
					}
				}
				else if (!PlayerInput.UsingGamepad && !Main.editSign && !Main.editChest && !Main.blockInput) {
					PlayerInput.Triggers.Current.CopyIntoDuringChat(this);
				}

				if (confused) {
					bool flag2 = controlLeft;
					bool flag3 = controlUp;
					controlLeft = controlRight;
					controlRight = flag2;
					controlUp = controlRight;
					controlDown = flag3;
				}
				else if (cartFlip) {
					if (controlRight || controlLeft) {
						bool flag4 = controlLeft;
						controlLeft = controlRight;
						controlRight = flag4;
					}
					else {
						cartFlip = false;
					}
				}

				for (int l = 0; l < doubleTapCardinalTimer.Length; l++) {
					doubleTapCardinalTimer[l]--;
					if (doubleTapCardinalTimer[l] < 0)
						doubleTapCardinalTimer[l] = 0;
				}

				for (int m = 0; m < 4; m++) {
					bool flag5 = false;
					bool flag6 = false;
					switch (m) {
						case 0:
							flag5 = controlDown && releaseDown;
							flag6 = controlDown;
							break;
						case 1:
							flag5 = controlUp && releaseUp;
							flag6 = controlUp;
							break;
						case 2:
							flag5 = controlRight && releaseRight;
							flag6 = controlRight;
							break;
						case 3:
							flag5 = controlLeft && releaseLeft;
							flag6 = controlLeft;
							break;
					}

					if (flag5) {
						if (doubleTapCardinalTimer[m] > 0)
							KeyDoubleTap(m);
						else
							doubleTapCardinalTimer[m] = 15;
					}

					if (flag6) {
						holdDownCardinalTimer[m]++;
						KeyHoldDown(m, holdDownCardinalTimer[m]);
					}
					else {
						holdDownCardinalTimer[m] = 0;
					}
				}

				controlDownHold = holdDownCardinalTimer[0] >= 45;

				PlayerLoader.SetControls(this);

				if (controlInv) {
					if (releaseInventory)
						ToggleInv();

					releaseInventory = false;
				}
				else {
					releaseInventory = true;
				}

				if (delayUseItem) {
					if (!controlUseItem)
						delayUseItem = false;

					controlUseItem = false;
				}

				if (itemAnimation == 0 && ItemTimeIsZero && reuseDelay == 0) {
					dropItemCheck();
					int num6 = selectedItem;
					bool flag7 = false;
					if (!Main.drawingPlayerChat && selectedItem != 58 && !Main.editSign && !Main.editChest) {
						if (PlayerInput.Triggers.Current.Hotbar1) {
							selectedItem = 0;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar2) {
							selectedItem = 1;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar3) {
							selectedItem = 2;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar4) {
							selectedItem = 3;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar5) {
							selectedItem = 4;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar6) {
							selectedItem = 5;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar7) {
							selectedItem = 6;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar8) {
							selectedItem = 7;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar9) {
							selectedItem = 8;
							flag7 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar10) {
							selectedItem = 9;
							flag7 = true;
						}

						int selectedBinding = DpadRadial.SelectedBinding;
						int selectedBinding2 = CircularRadial.SelectedBinding;
						_ = QuicksRadial.SelectedBinding;
						DpadRadial.Update();
						CircularRadial.Update();
						QuicksRadial.Update();
						if (CircularRadial.SelectedBinding >= 0 && selectedBinding2 != CircularRadial.SelectedBinding)
							DpadRadial.ChangeSelection(-1);

						if (DpadRadial.SelectedBinding >= 0 && selectedBinding != DpadRadial.SelectedBinding)
							CircularRadial.ChangeSelection(-1);

						if (QuicksRadial.SelectedBinding != -1 && PlayerInput.Triggers.JustReleased.RadialQuickbar && !PlayerInput.MiscSettingsTEMP.HotbarRadialShouldBeUsed) {
							switch (QuicksRadial.SelectedBinding) {
								case 0:
									QuickMount();
									break;
								case 1:
									QuickHeal();
									break;
								case 2:
									QuickBuff();
									break;
								case 3:
									QuickMana();
									break;
							}
						}

						if (controlTorch || flag7) {
							DpadRadial.ChangeSelection(-1);
							CircularRadial.ChangeSelection(-1);
						}
						/*
						if (controlTorch && flag7) {
						*/
						// TML: minor tweak, smart select item is held with controlUse even when item cannot be used right now.
						// In any case where nonTorch has a value, we should be setting nonTorch instead of selectedItem
						if (nonTorch != -1 && flag7) {
							if (selectedItem != nonTorch)
								SoundEngine.PlaySound(12);

							nonTorch = selectedItem;
							selectedItem = num6;
							flag7 = false;
						}
					}

					bool flag8 = Main.hairWindow;
					if (flag8) {
						int y = Main.screenHeight / 2 + 60;
						flag8 = new Rectangle(Main.screenWidth / 2 - TextureAssets.HairStyleBack.Width() / 2, y, TextureAssets.HairStyleBack.Width(), TextureAssets.HairStyleBack.Height()).Contains(Main.MouseScreen.ToPoint());
					}

					if (flag7 && CaptureManager.Instance.Active)
						CaptureManager.Instance.Active = false;

					if (num6 != selectedItem)
						SoundEngine.PlaySound(12);

					if (Main.mapFullscreen) {
						float num7 = PlayerInput.ScrollWheelDelta / 120;
						if (PlayerInput.UsingGamepad)
							num7 += (float)(PlayerInput.Triggers.Current.HotbarPlus.ToInt() - PlayerInput.Triggers.Current.HotbarMinus.ToInt()) * 0.1f;

						Main.mapFullscreenScale *= 1f + num7 * 0.3f;
					}
					else if (CaptureManager.Instance.Active) {
						CaptureManager.Instance.Scrolling();
					}
					else if (!flag8) {
						if (PlayerInput.MouseInModdedUI.Count > 0) { } else
						if (!Main.playerInventory) {
							HandleHotbar();
						}
						else {
							int num8 = GetMouseScrollDelta();
							bool flag9 = true;
							if (Main.recBigList) {
								int num9 = 42;
								int num10 = 340;
								int num11 = 310;
								PlayerInput.SetZoom_UI();
								int num12 = (Main.screenWidth - num11 - 280) / num9;
								int num13 = (Main.screenHeight - num10 - 20) / num9;
								if (new Rectangle(num11, num10, num12 * num9, num13 * num9).Contains(Main.MouseScreen.ToPoint())) {
									num8 *= -1;
									int num14 = Math.Sign(num8);
									while (num8 != 0) {
										if (num8 < 0) {
											Main.recStart -= num12;
											if (Main.recStart < 0)
												Main.recStart = 0;
										}
										else {
											Main.recStart += num12;
											if (Main.recStart > Main.numAvailableRecipes - num12)
												Main.recStart = Main.numAvailableRecipes - num12;
										}

										num8 -= num14;
									}
								}

								PlayerInput.SetZoom_World();
							}

							if (flag9) {
								Main.focusRecipe += num8;
								if (Main.focusRecipe > Main.numAvailableRecipes - 1)
									Main.focusRecipe = Main.numAvailableRecipes - 1;

								// Extra patch context.
								if (Main.focusRecipe < 0)
									Main.focusRecipe = 0;
							}
						}

						PlayerInput.MouseInModdedUI.Clear();
					}
				}
				else {
					bool flag10 = false;
					if (!Main.drawingPlayerChat && selectedItem != 58 && !Main.editSign && !Main.editChest) {
						int num15 = -1;
						// TML: Fix for digit keys being incorrectly checked instead of Hotbar hotkeys. Should be fixed in 1.4.5.
						if (PlayerInput.Triggers.Current.Hotbar1) { 
							num15 = 0;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar2) {
							num15 = 1;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar3) {
							num15 = 2;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar4) {
							num15 = 3;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar5) {
							num15 = 4;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar6) {
							num15 = 5;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar7) {
							num15 = 6;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar8) {
							num15 = 7;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar9) {
							num15 = 8;
							flag10 = true;
						}

						if (PlayerInput.Triggers.Current.Hotbar10) {
							num15 = 9;
							flag10 = true;
						}

						if (flag10) {
							if (num15 != nonTorch)
								SoundEngine.PlaySound(12);

							selectItemOnNextUse = true; // Added by TML
							nonTorch = num15;
						}
					}
				}
			}

			/* Moved into ItemCheck
			if (selectedItem != 58)
				SmartSelectLookup();
			*/

			if (stoned != lastStoned) {
				if (whoAmI == Main.myPlayer && stoned) {
					int damage = (int)(20.0 * (double)Main.GameModeInfo.EnemyDamageMultiplier);
					Hurt(PlayerDeathReason.ByOther(5), damage, 0);
				}

				SoundEngine.PlaySound(0, (int)position.X, (int)position.Y);
				for (int n = 0; n < 20; n++) {
					int num16 = Dust.NewDust(position, width, height, 1);
					if (Main.rand.Next(2) == 0)
						Main.dust[num16].noGravity = true;
				}
			}

			lastStoned = stoned;
			if (frozen || webbed || stoned) {
				controlJump = false;
				controlDown = false;
				controlLeft = false;
				controlRight = false;
				controlUp = false;
				controlUseItem = false;
				controlUseTile = false;
				controlThrow = false;
				gravDir = 1f;
			}

			if (!controlThrow)
				releaseThrow = true;
			else
				releaseThrow = false;

			if (controlDown && releaseDown) {
				if (tryKeepingHoveringUp)
					tryKeepingHoveringUp = false;
				else
					tryKeepingHoveringDown = true;
			}

			if (controlUp && releaseUp) {
				if (tryKeepingHoveringDown)
					tryKeepingHoveringDown = false;
				else
					tryKeepingHoveringUp = true;
			}

			if (velocity.Y == 0f) {
				tryKeepingHoveringUp = false;
				tryKeepingHoveringDown = false;
			}

			if (Settings.HoverControl == Settings.HoverControlMode.Hold) {
				tryKeepingHoveringUp = false;
				tryKeepingHoveringDown = false;
			}

			TrySyncingInput();
			if (Main.playerInventory)
				AdjTiles();

			HandleBeingInChestRange();
			tileEntityAnchor.GetTileEntity()?.OnPlayerUpdate(this);
		}

		if (i == Main.myPlayer) {
			if (velocity.Y <= 0f)
				fallStart2 = (int)(position.Y / 16f);

			if (velocity.Y == 0f) {
				int num17 = 25;
				num17 += extraFall;
				int num18 = (int)(position.Y / 16f) - fallStart;
				if (mount.CanFly())
					num18 = 0;

				if (mount.Cart && Minecart.OnTrack(position, width, height))
					num18 = 0;

				if (mount.Type == 1)
					num18 = 0;

				if (num18 > 0 || (gravDir == -1f && num18 < 0)) {
					int num19 = (int)(position.X / 16f);
					int num20 = (int)((position.X + (float)width) / 16f);
					int num21 = (int)((position.Y + (float)height + 1f) / 16f);
					if (gravDir == -1f)
						num21 = (int)((position.Y - 1f) / 16f);

					for (int num22 = num19; num22 <= num20; num22++) {
						/*
						if (Main.tile[num22, num21] != null && Main.tile[num22, num21].active() && (Main.tile[num22, num21].type == 189 || Main.tile[num22, num21].type == 196 || Main.tile[num22, num21].type == 460 || Main.tile[num22, num21].type == 666)) {
						*/
						if (Main.tile[num22, num21] != null && Main.tile[num22, num21].active() && TileID.Sets.NegatesFallDamage[Main.tile[num22, num21].type]) {
							num18 = 0;
							break;
						}
					}
				}

				/*
				bool flag11 = false;
				for (int num23 = 3; num23 < 10; num23++) {
					if (armor[num23].stack > 0 && armor[num23].wingSlot > -1)
						flag11 = true;
				}
				*/
				bool flag11 = equippedWings != null;

				if (stoned) {
					int num24 = (int)(((float)num18 * gravDir - 2f) * 20f);
					if (num24 > 0) {
						Hurt(PlayerDeathReason.ByOther(5), num24, 0);
						immune = false;
					}
				}
				else if (((gravDir == 1f && num18 > num17) || (gravDir == -1f && num18 < -num17)) && !noFallDmg && !flag11) {
					immune = false;
					int num25 = (int)((float)num18 * gravDir - (float)num17) * 10;
					if (mount.Active)
						num25 = (int)((float)num25 * mount.FallDamage);

					Hurt(PlayerDeathReason.ByOther(0), num25, 0);
					if (!dead && statLife <= statLifeMax2 / 10)
						AchievementsHelper.HandleSpecialEvent(this, 8);
				}

				fallStart = (int)(position.Y / 16f);
			}

			if (jump > 0 || rocketDelay > 0 || wet || slowFall || (double)num5 < 0.8 || tongued)
				fallStart = (int)(position.Y / 16f);
		}

		if (Main.netMode != 1) {
			if (chest == -1 && lastChest >= 0 && Main.chest[lastChest] != null) {
				int x = Main.chest[lastChest].x;
				int y2 = Main.chest[lastChest].y;
				NPC.BigMimicSummonCheck(x, y2, this);
			}

			if (lastChest != chest && chest >= 0 && Main.chest[chest] != null) {
				int x2 = Main.chest[chest].x;
				int y3 = Main.chest[chest].y;
				Projectile.GasTrapCheck(x2, y3, this);
				ItemSlot.forceClearGlowsOnChest = true;
			}

			lastChest = chest;
		}

		if (mouseInterface)
			delayUseItem = true;

		tileTargetX = (int)(((float)Main.mouseX + Main.screenPosition.X) / 16f);
		tileTargetY = (int)(((float)Main.mouseY + Main.screenPosition.Y) / 16f);
		if (gravDir == -1f)
			tileTargetY = (int)((Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY) / 16f);

		if (tileTargetX >= Main.maxTilesX - 5)
			tileTargetX = Main.maxTilesX - 5;

		if (tileTargetY >= Main.maxTilesY - 5)
			tileTargetY = Main.maxTilesY - 5;

		if (tileTargetX < 5)
			tileTargetX = 5;

		if (tileTargetY < 5)
			tileTargetY = 5;

		if (Main.tile[tileTargetX - 1, tileTargetY] == null)
			Main.tile[tileTargetX - 1, tileTargetY] = new Tile();

		if (Main.tile[tileTargetX + 1, tileTargetY] == null)
			Main.tile[tileTargetX + 1, tileTargetY] = new Tile();

		if (Main.tile[tileTargetX, tileTargetY] == null)
			Main.tile[tileTargetX, tileTargetY] = new Tile();

		if (inventory[selectedItem].axe > 0 && !Main.tile[tileTargetX, tileTargetY].active() && inventory[selectedItem].createWall <= 0 && (inventory[selectedItem].hammer <= 0 || inventory[selectedItem].axe != 0)) {
			if (Main.tile[tileTargetX - 1, tileTargetY].active() && Main.tile[tileTargetX - 1, tileTargetY].type == 323) {
				if (Main.tile[tileTargetX - 1, tileTargetY].frameY > 4)
					tileTargetX--;
			}
			else if (Main.tile[tileTargetX + 1, tileTargetY].active() && Main.tile[tileTargetX + 1, tileTargetY].type == 323 && Main.tile[tileTargetX + 1, tileTargetY].frameY < -4) {
				tileTargetX++;
			}
		}

		if (i == Main.myPlayer)
			UpdateNearbyInteractibleProjectilesList();

		try {
			if (whoAmI == Main.myPlayer && Main.instance.IsActive) {
				SmartCursorHelper.SmartCursorLookup(this);
				SmartInteractLookup();
			}
		}
		catch {
			Main.SmartCursorWanted_GamePad = false;
			Main.SmartCursorWanted_Mouse = false;
		}

		UpdateImmunity();
		if (petalTimer > 0)
			petalTimer--;

		if (shadowDodgeTimer > 0)
			shadowDodgeTimer--;

		if (boneGloveTimer > 0)
			boneGloveTimer--;

		if (crystalLeafCooldown > 0)
			crystalLeafCooldown--;

		if (jump > 0 || velocity.Y != 0f)
			ResetFloorFlags();

		bool flag12 = pStone;
		potionDelayTime = Item.potionDelay;
		restorationDelayTime = Item.restorationDelay;
		mushroomDelayTime = Item.mushroomDelay;
		if (pStone) {
			potionDelayTime = (int)((float)potionDelayTime * PhilosopherStoneDurationMultiplier);
			restorationDelayTime = (int)((float)restorationDelayTime * PhilosopherStoneDurationMultiplier);
			mushroomDelayTime = (int)((float)mushroomDelayTime * PhilosopherStoneDurationMultiplier);
		}

		if (yoraiz0rEye > 0)
			Yoraiz0rEye();

		ResetEffects();
		UpdateDyes();
		if (CreativePowerManager.Instance.GetPower<CreativePowers.GodmodePower>().IsEnabledForPlayer(whoAmI))
			creativeGodMode = true;

		if (IsStandingStillForSpecialEffects && itemAnimation == 0)
			afkCounter++;
		else
			afkCounter = 0;

		// TML:
		// This, right here, is the principal cause of crit chance being a massive pain.
		// By commenting this out, your critical strike chance for the vanilla "three" classes capable of crits will no longer be modified based on your current weapon.
		// This fixes a number of issues related to tooltip crit displays, and while it isn't the primary fix for crit swap, it definitely contributes to it.
		// - Thomas
		/*
		meleeCrit += inventory[selectedItem].crit;
		magicCrit += inventory[selectedItem].crit;
		rangedCrit += inventory[selectedItem].crit;
		*/
		if (whoAmI == Main.myPlayer) {
			Main.musicBox2 = -1;
			if (Main.SceneMetrics.WaterCandleCount > 0)
				AddBuff(86, 2, quiet: false);

			if (Main.SceneMetrics.PeaceCandleCount > 0)
				AddBuff(157, 2, quiet: false);

			if (Main.SceneMetrics.ShadowCandleCount > 0)
				AddBuff(350, 2, quiet: false);

			if (Main.SceneMetrics.HasCampfire)
				AddBuff(87, 2, quiet: false);

			if (Main.SceneMetrics.HasCatBast)
				AddBuff(215, 2, quiet: false);

			if (Main.SceneMetrics.HasStarInBottle)
				AddBuff(158, 2, quiet: false);

			if (Main.SceneMetrics.HasHeartLantern)
				AddBuff(89, 2, quiet: false);

			if (Main.SceneMetrics.HasSunflower)
				AddBuff(146, 2, quiet: false);

			if (Main.SceneMetrics.hasBanner)
				AddBuff(147, 2, quiet: false);

			if (!behindBackWall && ZoneSandstorm)
				AddBuff(194, 2, quiet: false);
		}

		PlayerLoader.PreUpdateBuffs(this);

		for (int num26 = 0; num26 < BuffLoader.BuffCount; num26++) {
			buffImmune[num26] = false;
		}

		UpdateProjectileCaches(i);
		UpdateBuffs(i);

		PlayerLoader.PostUpdateBuffs(this);

		// Moved from ItemCheck_OwnerOnlyCode/DashMovement/GetWeaponKnockback
		if (kbBuff)
			allKB *= 1.5f;

		if (whoAmI == Main.myPlayer) {
			if (!onFire && !poisoned)
				trapDebuffSource = false;

			UpdatePet(i);
			UpdatePetLight(i);
			isOperatingAnotherEntity = ownedProjectileCounts[1020] > 0;
		}

		bool flag13 = wet && !lavaWet && (!mount.Active || !mount.IsConsideredASlimeMount);
		if (accMerman && flag13) {
			releaseJump = true;
			wings = 0;
			merman = true;
			accFlipper = true;
			AddBuff(34, 2);
		}
		else {
			merman = false;
		}

		if (!flag13 && forceWerewolf)
			forceMerman = false;

		if (forceMerman && flag13)
			wings = 0;

		accMerman = false;
		hideMerman = false;
		forceMerman = false;
		if (wolfAcc && !merman && !Main.dayTime && !wereWolf)
			AddBuff(28, 60);

		wolfAcc = false;
		hideWolf = false;
		forceWerewolf = false;
		if (whoAmI == Main.myPlayer) {
			for (int num27 = 0; num27 < maxBuffs; num27++) {
				if (buffType[num27] > 0 && buffTime[num27] <= 0)
					DelBuff(num27);
			}
		}

		beetleDefense = false;
		beetleOffense = false;
		setSolar = false;
		head = armor[0].headSlot;
		body = armor[1].bodySlot;
		legs = armor[2].legSlot;
		ResetVisibleAccessories();
		if (MountFishronSpecialCounter > 0f)
			MountFishronSpecialCounter -= 1f;

		if (_portalPhysicsTime > 0)
			_portalPhysicsTime--;

		UpdateEquips(i);
		if (Main.npcShop <= 0)
			discountAvailable = discountEquipped;

		if (flag12 != pStone)
			AdjustRemainingPotionSickness();

		UpdatePermanentBoosters();
		UpdateLuck();
		shimmerUnstuckHelper.Update(this);
		UpdatePortableStoolUsage();
		if (velocity.Y == 0f || controlJump)
			portalPhysicsFlag = false;

		if (inventory[selectedItem].type == 3384 || portalPhysicsFlag)
			_portalPhysicsTime = 30;

		if (mount.Active)
			mount.UpdateEffects(this);

		gemCount++;
		if (gemCount >= 10) {
			gem = -1;
			ownedLargeGems = (byte)0;
			gemCount = 0;
			for (int num28 = 0; num28 <= 58; num28++) {
				if (inventory[num28].type == 0 || inventory[num28].stack == 0)
					inventory[num28].TurnToAir();

				if (inventory[num28].type >= 1522 && inventory[num28].type <= 1527) {
					gem = inventory[num28].type - 1522;
					ownedLargeGems[gem] = true;
				}

				if (inventory[num28].type == 3643) {
					gem = 6;
					ownedLargeGems[gem] = true;
				}
			}
		}

		UpdateArmorLights();
		UpdateArmorSets(i);
		if (shadowDodge && !onHitDodge)
			ClearBuff(59);


		//TODO: Move down?
		PlayerLoader.PostUpdateEquips(this);

		if (maxTurretsOld != maxTurrets) {
			UpdateMaxTurrets();
			maxTurretsOld = maxTurrets;
		}

		if (shieldRaised)
			statDefense += 20;

		if ((merman || forceMerman) && flag13)
			wings = 0;

		if (invis) {
			if (itemAnimation == 0 && aggro > -750)
				aggro = -750;
			else if (aggro > -250)
				aggro = -250;
		}

		if (inventory[selectedItem].type == 3106) {
			if (itemAnimation > 0) {
				stealthTimer = 15;
				if (stealth > 0f)
					stealth += 0.1f;
			}
			else if ((double)velocity.X > -0.1 && (double)velocity.X < 0.1 && (double)velocity.Y > -0.1 && (double)velocity.Y < 0.1 && !mount.Active) {
				if (stealthTimer == 0 && stealth > 0f) {
					stealth -= 0.02f;
					if ((double)stealth <= 0.0) {
						stealth = 0f;
						if (Main.netMode == 1)
							NetMessage.SendData(84, -1, -1, null, whoAmI);
					}
				}
			}
			else {
				if (stealth > 0f)
					stealth += 0.1f;

				if (mount.Active)
					stealth = 1f;
			}

			if (stealth > 1f)
				stealth = 1f;

			meleeDamage += (1f - stealth) * 3f;
			meleeCrit += (int)((1f - stealth) * 30f);

			// Psycho Knife knockback. Moved from ItemCheck_OwnerOnlyCode/GetWeaponKnockback
			GetKnockback(DamageClass.Melee) *= 1f + (1f - stealth);

			/*
			if (meleeCrit > 100)
				meleeCrit = 100;
			*/
			aggro -= (int)((1f - stealth) * 750f);
			if (stealthTimer > 0)
				stealthTimer--;
		}
		else if (shroomiteStealth) {
			if (itemAnimation > 0)
				stealthTimer = 5;

			if ((double)velocity.X > -0.1 && (double)velocity.X < 0.1 && (double)velocity.Y > -0.1 && (double)velocity.Y < 0.1 && !mount.Active) {
				if (stealthTimer == 0 && stealth > 0f) {
					stealth -= 0.015f;
					if ((double)stealth <= 0.0) {
						stealth = 0f;
						if (Main.netMode == 1)
							NetMessage.SendData(84, -1, -1, null, whoAmI);
					}
				}
			}
			else {
				float num29 = Math.Abs(velocity.X) + Math.Abs(velocity.Y);
				stealth += num29 * 0.0075f;
				if (stealth > 1f)
					stealth = 1f;

				if (mount.Active)
					stealth = 1f;
			}

			rangedDamage += (1f - stealth) * 0.6f;
			rangedCrit += (int)((1f - stealth) * 10f);

			// Stealth knockback. Moved from GetWeaponKnockback
			GetKnockback(DamageClass.Ranged) *= 1f + (1f - stealth) * 0.5f;

			aggro -= (int)((1f - stealth) * 750f);
			if (stealthTimer > 0)
				stealthTimer--;
		}
		else if (setVortex) {
			bool flag14 = false;
			if (vortexStealthActive) {
				float num30 = stealth;
				stealth -= 0.04f;
				if (stealth < 0f)
					stealth = 0f;
				else
					flag14 = true;

				if (stealth == 0f && num30 != stealth && Main.netMode == 1)
					NetMessage.SendData(84, -1, -1, null, whoAmI);

				rangedDamage += (1f - stealth) * 0.8f;
				rangedCrit += (int)((1f - stealth) * 20f);

				// Stealth knockback. Moved from GetWeaponKnockback
				GetKnockback(DamageClass.Ranged) *= 1f + (1f - stealth) * 0.5f;

				aggro -= (int)((1f - stealth) * 1200f);
				accRunSpeed *= 0.3f;
				maxRunSpeed *= 0.3f;
				if (mount.Active)
					vortexStealthActive = false;
			}
			else {
				float num31 = stealth;
				stealth += 0.04f;
				if (stealth > 1f)
					stealth = 1f;
				else
					flag14 = true;

				if (stealth == 1f && num31 != stealth && Main.netMode == 1)
					NetMessage.SendData(84, -1, -1, null, whoAmI);
			}

			if (flag14) {
				if (Main.rand.Next(2) == 0) {
					Vector2 vector = Vector2.UnitY.RotatedByRandom(6.2831854820251465);
					Dust obj2 = Main.dust[Dust.NewDust(base.Center - vector * 30f, 0, 0, 229)];
					obj2.noGravity = true;
					obj2.position = base.Center - vector * Main.rand.Next(5, 11);
					obj2.velocity = vector.RotatedBy(1.5707963705062866) * 4f;
					obj2.scale = 0.5f + Main.rand.NextFloat();
					obj2.fadeIn = 0.5f;
				}

				if (Main.rand.Next(2) == 0) {
					Vector2 vector2 = Vector2.UnitY.RotatedByRandom(6.2831854820251465);
					Dust obj3 = Main.dust[Dust.NewDust(base.Center - vector2 * 30f, 0, 0, 240)];
					obj3.noGravity = true;
					obj3.position = base.Center - vector2 * 12f;
					obj3.velocity = vector2.RotatedBy(-1.5707963705062866) * 2f;
					obj3.scale = 0.5f + Main.rand.NextFloat();
					obj3.fadeIn = 0.5f;
				}
			}
		}
		else {
			stealth = 1f;
		}

		if (manaSick)
			magicDamage *= 1f - manaSickReduction;

		// Attack speed multipliers now applied in Player.GetWeaponAttackSpeed.
		/*
		float num32 = meleeSpeed - 1f;
		num32 *= ItemID.Sets.BonusMeleeSpeedMultiplier[inventory[selectedItem].type];
		meleeSpeed = 1f + num32;
		*/
		if (tileSpeed > 3f)
			tileSpeed = 3f;

		tileSpeed = 1f / tileSpeed;
		if (wallSpeed > 3f)
			wallSpeed = 3f;

		wallSpeed = 1f / wallSpeed;

		// Allow mana stat to exceed vanilla bounds (#HealthManaAPI)
		/*
		if (statManaMax2 > 400)
			statManaMax2 = 400;
		*/

		// positive value capping built-in to DefenseStat
		/*
		if (statDefense < 0)
			statDefense = 0;
		*/

		if (slowOgreSpit) {
			moveSpeed /= 3f;
			if (velocity.Y == 0f && Math.Abs(velocity.X) > 1f)
				velocity.X /= 2f;
		}
		else if (dazed) {
			moveSpeed /= 3f;
		}
		else if (slow) {
			moveSpeed /= 2f;
		}
		else if (chilled) {
			moveSpeed *= 0.75f;
		}

		if (shieldRaised) {
			moveSpeed /= 3f;
			if (velocity.Y == 0f && Math.Abs(velocity.X) > 3f)
				velocity.X /= 2f;
		}

		if (DD2Event.Ongoing) {
			DD2Event.FindArenaHitbox();
			if (DD2Event.ShouldBlockBuilding(base.Center)) {
				noBuilding = true;
				AddBuff(199, 3);
			}
		}

		if ((double)pickSpeed < 0.3)
			pickSpeed = 0.3f;

		CapAttackSpeeds();

		PlayerLoader.PostUpdateMiscEffects(this);

		UpdateLifeRegen();
		soulDrain = 0;
		UpdateManaRegen();
		if (manaRegenCount < 0)
			manaRegenCount = 0;

		if (statMana > statManaMax2)
			statMana = statManaMax2;

		runAcceleration *= moveSpeed;
		maxRunSpeed *= moveSpeed;
		UpdateJumpHeight();
		for (int num33 = 0; num33 < maxBuffs; num33++) {
			if (buffType[num33] > 0 && buffTime[num33] > 0 && buffImmune[buffType[num33]])
				DelBuff(num33);
		}

		if (brokenArmor)
			statDefense /= 2;

		if (witheredArmor)
			statDefense /= 2;

		if (witheredWeapon) {
			allDamage *= 0.5f;
			/*
			meleeDamage *= 0.5f;
			rangedDamage *= 0.5f;
			magicDamage *= 0.5f;
			minionDamage *= 0.5f;
			rangedMultDamage *= 0.5f;
			*/
		}

		lastTileRangeX = tileRangeX;
		lastTileRangeY = tileRangeY;
		if (mount.Active)
			movementAbilitiesCache.CopyFrom(this);
		else
			movementAbilitiesCache.PasteInto(this);

		if (mount.Active && mount.BlockExtraJumps) {
			ConsumeAllExtraJumps();
			/*
			canJumpAgain_Cloud = false;
			canJumpAgain_Sandstorm = false;
			canJumpAgain_Blizzard = false;
			canJumpAgain_Fart = false;
			canJumpAgain_Sail = false;
			canJumpAgain_Unicorn = false;
			canJumpAgain_Santank = false;
			canJumpAgain_WallOfFleshGoat = false;
			canJumpAgain_Basilisk = false;
			*/
		}
		else if (velocity.Y == 0f || sliding) {
			RefreshDoubleJumps();
		}
		else {
			ExtraJumpLoader.ConsumeAndStopUnavailableJumps(this);
			/*
			if (!hasJumpOption_Cloud)
				canJumpAgain_Cloud = false;

			if (!hasJumpOption_Sandstorm)
				canJumpAgain_Sandstorm = false;

			if (!hasJumpOption_Blizzard)
				canJumpAgain_Blizzard = false;

			if (!hasJumpOption_Fart)
				canJumpAgain_Fart = false;

			if (!hasJumpOption_Sail)
				canJumpAgain_Sail = false;

			if (!hasJumpOption_Unicorn)
				canJumpAgain_Unicorn = false;

			if (!hasJumpOption_Santank)
				canJumpAgain_Santank = false;

			if (!hasJumpOption_WallOfFleshGoat)
				canJumpAgain_WallOfFleshGoat = false;

			if (!hasJumpOption_Basilisk)
				canJumpAgain_Basilisk = false;
			*/
		}

		if (!carpet) {
			canCarpet = false;
			carpetFrame = -1;
		}
		else if (velocity.Y == 0f || sliding) {
			canCarpet = true;
			carpetTime = 0;
			carpetFrame = -1;
			carpetFrameCounter = 0f;
		}

		if (gravDir == -1f)
			canCarpet = false;

		if (ropeCount > 0)
			ropeCount--;

		if (!pulley && !frozen && !webbed && !stoned && !controlJump && gravDir == 1f && ropeCount == 0 && grappling[0] == -1 && !tongued && !mount.Active)
			FindPulley();

		UpdatePettingAnimal();
		sitting.UpdateSitting(this);
		sleeping.UpdateState(this);
		eyeHelper.Update(this);
		if (pulley) {
			if (mount.Active)
				pulley = false;

			sandStorm = false;
			CancelAllJumpVisualEffects();
			int num34 = (int)(position.X + (float)(width / 2)) / 16;
			int num35 = (int)(position.Y - 8f) / 16;
			bool flag15 = false;
			if (pulleyDir == 0)
				pulleyDir = 1;

			if (pulleyDir == 1) {
				if (direction == -1 && controlLeft && (releaseLeft || leftTimer == 0)) {
					pulleyDir = 2;
					flag15 = true;
				}
				else if ((direction == 1 && controlRight && releaseRight) || rightTimer == 0) {
					pulleyDir = 2;
					flag15 = true;
				}
				else {
					if (direction == 1 && controlLeft) {
						direction = -1;
						flag15 = true;
					}

					if (direction == -1 && controlRight) {
						direction = 1;
						flag15 = true;
					}
				}
			}
			else if (pulleyDir == 2) {
				if (direction == 1 && controlLeft) {
					flag15 = true;
					if (!Collision.SolidCollision(new Vector2(num34 * 16 + 8 - width / 2, position.Y), width, height)) {
						pulleyDir = 1;
						direction = -1;
						flag15 = true;
					}
				}

				if (direction == -1 && controlRight) {
					flag15 = true;
					if (!Collision.SolidCollision(new Vector2(num34 * 16 + 8 - width / 2, position.Y), width, height)) {
						pulleyDir = 1;
						direction = 1;
						flag15 = true;
					}
				}
			}

			int num36 = 1;
			if (controlLeft)
				num36 = -1;

			bool flag16 = CanMoveForwardOnRope(num36, num34, num35);
			if (controlLeft && direction == -1 && flag16)
				instantMovementAccumulatedThisFrame.X += -1f;

			if (controlRight && direction == 1 && flag16)
				instantMovementAccumulatedThisFrame.X += 1f;

			bool flag17 = false;
			if (!flag15 && ((controlLeft && (releaseLeft || leftTimer == 0)) || (controlRight && (releaseRight || rightTimer == 0)))) {
				int num37 = num34 + num36;
				if (WorldGen.IsRope(num37, num35)) {
					pulleyDir = 1;
					direction = num36;
					int num38 = num37 * 16 + 8 - width / 2;
					float y4 = position.Y;
					y4 = num35 * 16 + 22;
					if (Main.tile[num37, num35 - 1] == null)
						Main.tile[num37, num35 - 1] = new Tile();

					if (Main.tile[num37, num35 + 1] == null)
						Main.tile[num37, num35 + 1] = new Tile();

					if (WorldGen.IsRope(num37, num35 - 1) || WorldGen.IsRope(num37, num35 + 1))
						y4 = num35 * 16 + 22;

					if (Collision.SolidCollision(new Vector2(num38, y4), width, height)) {
						pulleyDir = 2;
						direction = -num36;
						num38 = ((direction != 1) ? (num37 * 16 + 8 - width / 2 + -6) : (num37 * 16 + 8 - width / 2 + 6));
					}

					if (i == Main.myPlayer)
						Main.cameraX = Main.cameraX + position.X - (float)num38;

					position.X = num38;
					gfxOffY = position.Y - y4;
					position.Y = y4;
					flag17 = true;
				}
			}

			if (!flag17 && !flag15 && !controlUp && ((controlLeft && releaseLeft) || (controlRight && releaseRight))) {
				pulley = false;
				if (controlLeft && velocity.X == 0f)
					velocity.X = -1f;

				if (controlRight && velocity.X == 0f)
					velocity.X = 1f;
			}

			if (velocity.X != 0f)
				pulley = false;

			if (Main.tile[num34, num35] == null)
				Main.tile[num34, num35] = new Tile();

			if (!WorldGen.IsRope(num34, num35))
				pulley = false;

			if (gravDir != 1f)
				pulley = false;

			if (frozen || webbed || stoned)
				pulley = false;

			if (!pulley)
				velocity.Y -= gravity;

			if (controlJump) {
				pulley = false;
				jump = jumpHeight;
				velocity.Y = 0f - jumpSpeed;
			}
		}

		if (grapCount > 0)
			pulley = false;

		if (NPC.brainOfGravity >= 0 && NPC.brainOfGravity < 200 && Vector2.Distance(base.Center, Main.npc[NPC.brainOfGravity].Center) < 4000f)
			forcedGravity = 10;

		if (forcedGravity > 0)
			gravDir = -1f;

		if (pulley) {
			fallStart = (int)position.Y / 16;
			wingFrame = 0;
			if (wings == 4)
				wingFrame = 3;

			int num39 = (int)(position.X + (float)(width / 2)) / 16;
			int num40 = (int)(position.Y - 16f) / 16;
			int num41 = (int)(position.Y - 8f) / 16;
			bool flag18 = true;
			bool flag19 = false;
			if (WorldGen.IsRope(num39, num41 - 1) || WorldGen.IsRope(num39, num41 + 1))
				flag19 = true;

			if (Main.tile[num39, num40] == null)
				Main.tile[num39, num40] = new Tile();

			if (!WorldGen.IsRope(num39, num40)) {
				flag18 = false;
				if (velocity.Y < 0f)
					velocity.Y = 0f;
			}

			if (flag19) {
				if (controlUp && flag18) {
					float x3 = position.X;
					float y5 = position.Y - Math.Abs(velocity.Y) - 2f;
					if (Collision.SolidCollision(new Vector2(x3, y5), width, height)) {
						x3 = num39 * 16 + 8 - width / 2 + 6;
						if (!Collision.SolidCollision(new Vector2(x3, y5), width, (int)((float)height + Math.Abs(velocity.Y) + 2f))) {
							if (i == Main.myPlayer)
								Main.cameraX = Main.cameraX + position.X - x3;

							pulleyDir = 2;
							direction = 1;
							position.X = x3;
							velocity.X = 0f;
						}
						else {
							x3 = num39 * 16 + 8 - width / 2 + -6;
							if (!Collision.SolidCollision(new Vector2(x3, y5), width, (int)((float)height + Math.Abs(velocity.Y) + 2f))) {
								if (i == Main.myPlayer)
									Main.cameraX = Main.cameraX + position.X - x3;

								pulleyDir = 2;
								direction = -1;
								position.X = x3;
								velocity.X = 0f;
							}
						}
					}

					if (velocity.Y > 0f)
						velocity.Y *= 0.7f;

					if (velocity.Y > -3f)
						velocity.Y -= 0.2f;
					else
						velocity.Y -= 0.02f;

					if (velocity.Y < -8f)
						velocity.Y = -8f;
				}
				else if (controlDown) {
					float x4 = position.X;
					float y6 = position.Y;
					if (Collision.SolidCollision(new Vector2(x4, y6), width, (int)((float)height + Math.Abs(velocity.Y) + 2f))) {
						x4 = num39 * 16 + 8 - width / 2 + 6;
						if (!Collision.SolidCollision(new Vector2(x4, y6), width, (int)((float)height + Math.Abs(velocity.Y) + 2f))) {
							if (i == Main.myPlayer)
								Main.cameraX = Main.cameraX + position.X - x4;

							pulleyDir = 2;
							direction = 1;
							position.X = x4;
							velocity.X = 0f;
						}
						else {
							x4 = num39 * 16 + 8 - width / 2 + -6;
							if (!Collision.SolidCollision(new Vector2(x4, y6), width, (int)((float)height + Math.Abs(velocity.Y) + 2f))) {
								if (i == Main.myPlayer)
									Main.cameraX = Main.cameraX + position.X - x4;

								pulleyDir = 2;
								direction = -1;
								position.X = x4;
								velocity.X = 0f;
							}
						}
					}

					if (velocity.Y < 0f)
						velocity.Y *= 0.7f;

					if (velocity.Y < 3f)
						velocity.Y += 0.2f;
					else
						velocity.Y += 0.1f;

					if (velocity.Y > maxFallSpeed)
						velocity.Y = maxFallSpeed;
				}
				else {
					velocity.Y *= 0.7f;
					if ((double)velocity.Y > -0.1 && (double)velocity.Y < 0.1)
						velocity.Y = 0f;
				}
			}
			else if (controlDown) {
				ropeCount = 10;
				pulley = false;
				velocity.Y = 1f;
			}
			else {
				velocity.Y = 0f;
				position.Y = num40 * 16 + 22;
			}

			float num42 = num39 * 16 + 8 - width / 2;
			if (pulleyDir == 1)
				num42 = num39 * 16 + 8 - width / 2;

			if (pulleyDir == 2)
				num42 = num39 * 16 + 8 - width / 2 + 6 * direction;

			if (i == Main.myPlayer) {
				Main.cameraX += position.X - num42;
				Main.cameraX = MathHelper.Clamp(Main.cameraX, -32f, 32f);
			}

			position.X = num42;
			pulleyFrameCounter += Math.Abs(velocity.Y * 0.75f);
			if (velocity.Y != 0f)
				pulleyFrameCounter += 0.75f;

			if (pulleyFrameCounter > 10f) {
				pulleyFrame++;
				pulleyFrameCounter = 0f;
			}

			if (pulleyFrame > 1)
				pulleyFrame = 0;

			canCarpet = true;
			carpetFrame = -1;
			wingTime = wingTimeMax;
			rocketTime = rocketTimeMax;
			rocketDelay = 0;
			rocketFrame = false;
			canRocket = false;
			rocketRelease = false;
			DashMovement();
			UpdateControlHolds();
		}
		else if (grappling[0] == -1 && !tongued) {
			if (wingsLogic > 0 && velocity.Y != 0f && !merman && !mount.Active)
				WingAirLogicTweaks();

			if (empressBrooch)
				runAcceleration *= 1.75f;

			if (hasMagiluminescence && velocity.Y == 0f) {
				runAcceleration *= 1.75f;
				maxRunSpeed *= 1.15f;
				accRunSpeed *= 1.15f;
				runSlowdown *= 1.75f;
			}

			if (shadowArmor) {
				runAcceleration *= 1.75f;
				maxRunSpeed *= 1.15f;
				accRunSpeed *= 1.15f;
				runSlowdown *= 1.75f;
			}

			if (mount.Active && mount.Type == 43 && velocity.Y != 0f)
				runSlowdown = 0f;

			if (sticky) {
				maxRunSpeed *= 0.25f;
				runAcceleration *= 0.25f;
				runSlowdown *= 2f;
				if (velocity.X > maxRunSpeed)
					velocity.X = maxRunSpeed;

				if (velocity.X < 0f - maxRunSpeed)
					velocity.X = 0f - maxRunSpeed;
			}
			else if (powerrun) {
				maxRunSpeed *= 3.5f;
				runAcceleration *= 1f;
				runSlowdown *= 2f;
			}
			else if (runningOnSand && desertBoots) {
				float num43 = 1.75f;
				maxRunSpeed *= num43;
				accRunSpeed *= num43;
				runAcceleration *= num43;
				runSlowdown *= num43;
			}
			else if (slippy2) {
				runAcceleration *= 0.6f;
				runSlowdown = 0f;
				if (iceSkate) {
					runAcceleration *= 3.5f;
					maxRunSpeed *= 1.25f;
				}
			}
			else if (slippy) {
				runAcceleration *= 0.7f;
				if (iceSkate) {
					runAcceleration *= 3.5f;
					maxRunSpeed *= 1.25f;
				}
				else {
					runSlowdown *= 0.1f;
				}
			}

			/*
			if (sandStorm) {
				runAcceleration *= 1.5f;
				maxRunSpeed *= 2f;
			}

			if (isPerformingJump_Blizzard && hasJumpOption_Blizzard) {
				runAcceleration *= 3f;
				maxRunSpeed *= 1.5f;
			}

			if (isPerformingJump_Fart && hasJumpOption_Fart) {
				runAcceleration *= 3f;
				maxRunSpeed *= 1.75f;
			}

			if (isPerformingJump_Unicorn && hasJumpOption_Unicorn) {
				runAcceleration *= 3f;
				maxRunSpeed *= 1.5f;
			}

			if (isPerformingJump_Santank && hasJumpOption_Santank) {
				runAcceleration *= 3f;
				maxRunSpeed *= 1.5f;
			}

			if (isPerformingJump_WallOfFleshGoat && hasJumpOption_WallOfFleshGoat) {
				runAcceleration *= 3f;
				maxRunSpeed *= 1.5f;
			}

			if (isPerformingJump_Basilisk && hasJumpOption_Basilisk) {
				runAcceleration *= 3f;
				maxRunSpeed *= 1.5f;
			}

			if (isPerformingJump_Sail && hasJumpOption_Sail) {
				runAcceleration *= 1.5f;
				maxRunSpeed *= 1.25f;
			}
			*/

			ExtraJumpLoader.UpdateHorizontalSpeeds(this);

			if (carpetFrame != -1) {
				runAcceleration *= 1.25f;
				maxRunSpeed *= 1.5f;
			}

			if (inventory[selectedItem].type == 3106 && stealth < 1f) {
				float num44 = maxRunSpeed / 2f * (1f - stealth);
				maxRunSpeed -= num44;
				accRunSpeed = maxRunSpeed;
			}

			if (mount.Active) {
				rocketBoots = 0;
				vanityRocketBoots = 0;
				wings = 0;
				wingsLogic = 0;
				maxRunSpeed = mount.RunSpeed;
				accRunSpeed = mount.DashSpeed;
				runAcceleration = mount.Acceleration;
				if (mount.Type == 12 && !MountFishronSpecial) {
					runAcceleration /= 2f;
					maxRunSpeed /= 2f;
				}

				mount.AbilityRecovery();
				if (mount.Cart && velocity.Y == 0f) {
					if (!Minecart.OnTrack(position, width, height)) {
						fullRotation = 0f;
						onWrongGround = true;
						runSlowdown = 0.2f;
						if ((controlLeft && releaseLeft) || (controlRight && releaseRight))
							mount.Dismount(this);
					}
					else {
						runSlowdown = runAcceleration;
						onWrongGround = false;
					}
				}

				if (mount.Type == 8)
					mount.UpdateDrill(this, controlUp, controlDown);
			}

			PlayerLoader.PostUpdateRunSpeeds(this);

			HorizontalMovement();
			bool flag20 = !mount.Active;
			if (forcedGravity > 0) {
				gravDir = -1f;
			}
			else if (gravControl && flag20) {
				if (controlUp && releaseUp) {
					if (gravDir == 1f) {
						gravDir = -1f;
						fallStart = (int)(position.Y / 16f);
						jump = 0;
						SoundEngine.PlaySound(SoundID.Item8, position);
					}
					else {
						gravDir = 1f;
						fallStart = (int)(position.Y / 16f);
						jump = 0;
						SoundEngine.PlaySound(SoundID.Item8, position);
					}
				}
			}
			else if (gravControl2 && flag20) {
				if (controlUp && releaseUp) {
					if (gravDir == 1f) {
						gravDir = -1f;
						fallStart = (int)(position.Y / 16f);
						jump = 0;
						SoundEngine.PlaySound(SoundID.Item8, position);
					}
					else {
						gravDir = 1f;
						fallStart = (int)(position.Y / 16f);
						jump = 0;
						SoundEngine.PlaySound(SoundID.Item8, position);
					}
				}
			}
			else {
				gravDir = 1f;
			}

			if (velocity.Y == 0f && mount.Active && mount.CanHover() && controlUp && releaseUp)
				velocity.Y = 0f - (mount.Acceleration + gravity + 0.001f);

			UpdateControlHolds();
			sandStorm = false;
			JumpMovement();
			if (wingsLogic == 0)
				wingTime = 0f;

			if (rocketBoots == 0)
				rocketTime = 0;

			if (jump == 0)
				CancelAllJumpVisualEffects();

			DashMovement();
			WallslideMovement();
			CarpetMovement();
			DoubleJumpVisuals();
			if (wingsLogic > 0 || mount.Active)
				sandStorm = false;

			if (((gravDir == 1f && velocity.Y > 0f - jumpSpeed) || (gravDir == -1f && velocity.Y < jumpSpeed)) && velocity.Y != 0f)
				canRocket = true;

			bool flag21 = false;
			if (((velocity.Y == 0f || sliding) && releaseJump) || (autoJump && justJumped)) {
				mount.ResetFlightTime(velocity.X);
				wingTime = wingTimeMax;
			}

			if (wingsLogic > 0 && controlJump && wingTime > 0f && jump == 0 && velocity.Y != 0f)
				flag21 = true;

			if ((wingsLogic == 22 || wingsLogic == 28 || wingsLogic == 30 || wingsLogic == 32 || wingsLogic == 29 || wingsLogic == 33 || wingsLogic == 35 || wingsLogic == 37 || wingsLogic == 45) && controlJump && TryingToHoverDown && wingTime > 0f)
				flag21 = true;

			if (frozen || webbed || stoned) {
				if (mount.Active)
					mount.Dismount(this);

				velocity.Y += gravity;
				if (velocity.Y > maxFallSpeed)
					velocity.Y = maxFallSpeed;

				sandStorm = false;
				CancelAllJumpVisualEffects();
			}
			else {
				bool isCustomWings = ItemLoader.WingUpdate(this, flag21);
				if (flag21) {
					WingAirVisuals();
					WingMovement();
				}

				WingFrame(flag21, isCustomWings);
				if (wingsLogic > 0 && rocketBoots != 0 && velocity.Y != 0f && rocketTime != 0) {
					int num45 = 6;
					int num46 = rocketTime * num45;
					wingTime += num46;
					if (wingTime > (float)(wingTimeMax + num46))
						wingTime = wingTimeMax + num46;

					rocketTime = 0;
				}

				if (isCustomWings) { } else
				if (flag21 && wings != 4 && wings != 22 && wings != 0 && wings != 24 && wings != 28 && wings != 30 && wings != 33 && wings != 45) {
					bool flag22 = wingFrame == 3;
					if (wings == 43 || wings == 44)
						flag22 = wingFrame == 4;

					if (flag22) {
						if (!flapSound)
							SoundEngine.PlaySound(SoundID.Item32, position);

						flapSound = true;
					}
					else {
						flapSound = false;
					}
				}

				if (velocity.Y == 0f || sliding || (autoJump && justJumped))
					rocketTime = rocketTimeMax;

				if (empressBrooch)
					rocketTime = rocketTimeMax;

				if ((wingTime == 0f || wingsLogic == 0) && rocketBoots != 0 && controlJump && rocketDelay == 0 && canRocket && rocketRelease && !AnyExtraJumpUsable()) {
					if (rocketTime > 0) {
						rocketTime--;
						rocketDelay = 10;
						if (rocketDelay2 <= 0) {
							if (rocketBoots == 1)
								rocketDelay2 = 30;
							else if (rocketBoots == 2 || rocketBoots == 5 || rocketBoots == 3 || rocketBoots == 4)
								rocketDelay2 = 15;
						}

						if (rocketSoundDelay <= 0) {
							if (vanityRocketBoots == 1 || vanityRocketBoots == 5) {
								rocketSoundDelay = 30;
								SoundEngine.PlaySound(SoundID.Item13, position);
							}
							else if (vanityRocketBoots == 2 || vanityRocketBoots == 3 || vanityRocketBoots == 4) {
								rocketSoundDelay = 15;
								SoundEngine.PlaySound(SoundID.Item24, position);
							}
						}
					}
					else {
						canRocket = false;
					}
				}

				if (rocketSoundDelay > 0)
					rocketSoundDelay--;

				if (rocketDelay2 > 0)
					rocketDelay2--;

				if (rocketDelay == 0)
					rocketFrame = false;

				if (rocketDelay > 0) {
					rocketFrame = true;
					RocketBootVisuals();
					if (rocketDelay == 0)
						releaseJump = true;

					rocketDelay--;
					velocity.Y -= 0.1f * gravDir;
					if (gravDir == 1f) {
						if (velocity.Y > 0f)
							velocity.Y -= 0.5f;
						else if ((double)velocity.Y > (double)(0f - jumpSpeed) * 0.5)
							velocity.Y -= 0.1f;

						if (velocity.Y < (0f - jumpSpeed) * 1.5f)
							velocity.Y = (0f - jumpSpeed) * 1.5f;
					}
					else {
						if (velocity.Y < 0f)
							velocity.Y += 0.5f;
						else if ((double)velocity.Y < (double)jumpSpeed * 0.5)
							velocity.Y += 0.1f;

						if (velocity.Y > jumpSpeed * 1.5f)
							velocity.Y = jumpSpeed * 1.5f;
					}
				}
				else if (!flag21) {
					if (mount.CanHover()) {
						mount.Hover(this);
					}
					else if (mount.CanFly() && controlJump && jump == 0) {
						if (mount.Flight()) {
							if (TryingToHoverDown) {
								velocity.Y *= 0.9f;
								if (velocity.Y > -1f && (double)velocity.Y < 0.5)
									velocity.Y = 1E-05f;
							}
							else {
								float num47 = jumpSpeed;
								if (mount.Type == 50)
									num47 *= 0.5f;

								if (velocity.Y > 0f)
									velocity.Y -= 0.5f;
								else if ((double)velocity.Y > (double)(0f - num47) * 1.5)
									velocity.Y -= 0.1f;

								if (velocity.Y < (0f - num47) * 1.5f)
									velocity.Y = (0f - num47) * 1.5f;
							}
						}
						else {
							velocity.Y += gravity / 3f * gravDir;
							if (gravDir == 1f) {
								if (velocity.Y > maxFallSpeed / 3f && !TryingToHoverDown)
									velocity.Y = maxFallSpeed / 3f;
							}
							else if (velocity.Y < (0f - maxFallSpeed) / 3f && !TryingToHoverUp) {
								velocity.Y = (0f - maxFallSpeed) / 3f;
							}
						}
					}
					else if (slowFall && !TryingToHoverDown) {
						if (TryingToHoverUp)
							gravity = gravity / 10f * gravDir;
						else
							gravity = gravity / 3f * gravDir;

						velocity.Y += gravity;
					}
					else if (wingsLogic > 0 && controlJump && velocity.Y > 0f) {
						bool noLightEmittence = wingsLogic != wings;
						fallStart = (int)(position.Y / 16f);
						if (velocity.Y > 0f) {
							if (wings == 10 && Main.rand.Next(3) == 0) {
								int num48 = 4;
								if (direction == 1)
									num48 = -40;

								int num49 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num48, position.Y + (float)(height / 2) - 15f), 30, 30, 76, 0f, 0f, 50, default(Color), 0.6f);
								Main.dust[num49].fadeIn = 1.1f;
								Main.dust[num49].noGravity = true;
								Main.dust[num49].noLight = true;
								Main.dust[num49].velocity *= 0.3f;
								Main.dust[num49].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
							}

							if (wings == 34 && ShouldDrawWingsThatAreAlwaysAnimated() && Main.rand.Next(3) == 0) {
								int num50 = 4;
								if (direction == 1)
									num50 = -40;

								int num51 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num50, position.Y + (float)(height / 2) - 15f), 30, 30, 261, 0f, 0f, 50, default(Color), 0.6f);
								Main.dust[num51].fadeIn = 1.1f;
								Main.dust[num51].noGravity = true;
								Main.dust[num51].noLight = true;
								Main.dust[num51].noLightEmittence = noLightEmittence;
								Main.dust[num51].velocity *= 0.3f;
								Main.dust[num51].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
							}

							if (wings == 40)
								ShouldDrawWingsThatAreAlwaysAnimated();

							if (wings == 44)
								ShouldDrawWingsThatAreAlwaysAnimated();

							if (wings == 9 && Main.rand.Next(3) == 0) {
								int num52 = 8;
								if (direction == 1)
									num52 = -40;

								int num53 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num52, position.Y + (float)(height / 2) - 15f), 30, 30, 6, 0f, 0f, 200, default(Color), 2f);
								Main.dust[num53].noGravity = true;
								Main.dust[num53].velocity *= 0.3f;
								Main.dust[num53].noLightEmittence = noLightEmittence;
								Main.dust[num53].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
							}

							if (wings == 29 && Main.rand.Next(3) == 0) {
								int num54 = 8;
								if (direction == 1)
									num54 = -40;

								int num55 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num54, position.Y + (float)(height / 2) - 15f), 30, 30, 6, 0f, 0f, 100, default(Color), 2.4f);
								Main.dust[num55].noGravity = true;
								Main.dust[num55].velocity *= 0.3f;
								Main.dust[num55].noLightEmittence = noLightEmittence;
								if (Main.rand.Next(10) == 0)
									Main.dust[num55].fadeIn = 2f;

								Main.dust[num55].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
							}

							if (wings == 6) {
								if (Main.rand.Next(10) == 0) {
									int num56 = 4;
									if (direction == 1)
										num56 = -40;

									int num57 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num56, position.Y + (float)(height / 2) - 12f), 30, 20, 55, 0f, 0f, 200);
									Main.dust[num57].noLightEmittence = noLightEmittence;
									Main.dust[num57].velocity *= 0.3f;
									Main.dust[num57].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
								}
							}
							else if (wings == 5 && Main.rand.Next(6) == 0) {
								int num58 = 6;
								if (direction == 1)
									num58 = -30;

								int num59 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num58, position.Y), 18, height, 58, 0f, 0f, 255, default(Color), 1.2f);
								Main.dust[num59].velocity *= 0.3f;
								Main.dust[num59].noLightEmittence = noLightEmittence;
								Main.dust[num59].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
							}

							if (isCustomWings) { } else
							if (wings == 4) {
								rocketDelay2--;
								if (rocketDelay2 <= 0) {
									SoundEngine.PlaySound(SoundID.Item13, position);
									rocketDelay2 = 60;
								}

								int type = 6;
								float scale = 1.5f;
								int alpha = 100;
								float x5 = position.X + (float)(width / 2) + 16f;
								if (direction > 0)
									x5 = position.X + (float)(width / 2) - 26f;

								float num60 = position.Y + (float)height - 18f;
								if (Main.rand.Next(2) == 1) {
									x5 = position.X + (float)(width / 2) + 8f;
									if (direction > 0)
										x5 = position.X + (float)(width / 2) - 20f;

									num60 += 6f;
								}

								int num61 = Dust.NewDust(new Vector2(x5, num60), 8, 8, type, 0f, 0f, alpha, default(Color), scale);
								Main.dust[num61].velocity.X *= 0.3f;
								Main.dust[num61].velocity.Y += 10f;
								Main.dust[num61].noGravity = true;
								Main.dust[num61].noLightEmittence = noLightEmittence;
								Main.dust[num61].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
								wingFrameCounter++;
								if (wingFrameCounter > 4) {
									wingFrame++;
									wingFrameCounter = 0;
									if (wingFrame >= 3)
										wingFrame = 0;
								}
							}
							else if (wings != 22 && wings != 28) {
								if (wings == 30) {
									wingFrameCounter++;
									int num62 = 5;
									if (wingFrameCounter >= num62 * 3)
										wingFrameCounter = 0;

									wingFrame = 1 + wingFrameCounter / num62;
								}
								else if (wings == 34) {
									wingFrameCounter++;
									int num63 = 7;
									if (wingFrameCounter >= num63 * 6)
										wingFrameCounter = 0;

									wingFrame = wingFrameCounter / num63;
								}
								else if (wings != 45) {
									if (wings == 40) {
										wingFrame = 0;
									}
									else if (wings == 44) {
										wingFrame = 2;
									}
									else if (wings == 39) {
										wingFrameCounter++;
										int num64 = 12;
										if (wingFrameCounter >= num64 * 6)
											wingFrameCounter = 0;

										wingFrame = wingFrameCounter / num64;
									}
									else if (wings == 26) {
										int num65 = 6;
										if (direction == 1)
											num65 = -30;

										int num66 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num65, position.Y), 18, height, 217, 0f, 0f, 100, default(Color), 1.4f);
										Main.dust[num66].noGravity = true;
										Main.dust[num66].noLight = true;
										Main.dust[num66].velocity /= 4f;
										Main.dust[num66].velocity -= velocity;
										Main.dust[num66].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
										if (Main.rand.Next(2) == 0) {
											num65 = -24;
											if (direction == 1)
												num65 = 12;

											float num67 = position.Y;
											if (gravDir == -1f)
												num67 += (float)(height / 2);

											num66 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num65, num67), 12, height / 2, 217, 0f, 0f, 100, default(Color), 1.4f);
											Main.dust[num66].noGravity = true;
											Main.dust[num66].noLight = true;
											Main.dust[num66].velocity /= 4f;
											Main.dust[num66].velocity -= velocity;
											Main.dust[num66].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
										}

										wingFrame = 2;
									}
									else if (wings == 37) {
										Color color = Color.Lerp(Color.Black, Color.White, Main.rand.NextFloat());
										int num68 = 6;
										if (direction == 1)
											num68 = -30;

										int num69 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num68, position.Y), 24, height, Utils.SelectRandom<int>(Main.rand, 31, 31, 31), 0f, 0f, 100, default(Color), 0.7f);
										Main.dust[num69].noGravity = true;
										Main.dust[num69].noLight = true;
										Main.dust[num69].velocity /= 4f;
										Main.dust[num69].velocity -= velocity;
										Main.dust[num69].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
										if (Main.dust[num69].type == 55)
											Main.dust[num69].color = color;

										if (Main.rand.Next(3) == 0) {
											num68 = -24;
											if (direction == 1)
												num68 = 12;

											float num70 = position.Y;
											if (gravDir == -1f)
												num70 += (float)(height / 2);

											num69 = Dust.NewDust(new Vector2(position.X + (float)(width / 2) + (float)num68, num70), 12, height / 2, Utils.SelectRandom<int>(Main.rand, 31, 31, 31), 0f, 0f, 140, default(Color), 0.7f);
											Main.dust[num69].noGravity = true;
											Main.dust[num69].noLight = true;
											Main.dust[num69].velocity /= 4f;
											Main.dust[num69].velocity -= velocity;
											Main.dust[num69].shader = GameShaders.Armor.GetSecondaryShader(cWings, this);
											if (Main.dust[num69].type == 55)
												Main.dust[num69].color = color;
										}

										wingFrame = 2;
									}
									else if (wings != 24) {
										if (wings == 43)
											wingFrame = 1;
										else if (wings == 12)
											wingFrame = 3;
										else
											wingFrame = 2;
									}
								}
							}
						}

						velocity.Y += gravity / 3f * gravDir;
						if (gravDir == 1f) {
							if (velocity.Y > maxFallSpeed / 3f && !TryingToHoverDown)
								velocity.Y = maxFallSpeed / 3f;
						}
						else if (velocity.Y < (0f - maxFallSpeed) / 3f && !TryingToHoverUp) {
							velocity.Y = (0f - maxFallSpeed) / 3f;
						}
					}
					else if (cartRampTime <= 0) {
						velocity.Y += gravity * gravDir;
					}
					else {
						cartRampTime--;
					}
				}

				if (!mount.Active || mount.Type != 5) {
					if (gravDir == 1f) {
						if (velocity.Y > maxFallSpeed)
							velocity.Y = maxFallSpeed;

						if (slowFall && velocity.Y > maxFallSpeed / 3f && !TryingToHoverDown)
							velocity.Y = maxFallSpeed / 3f;

						if (slowFall && velocity.Y > maxFallSpeed / 5f && TryingToHoverUp)
							velocity.Y = maxFallSpeed / 10f;
					}
					else {
						if (velocity.Y < 0f - maxFallSpeed)
							velocity.Y = 0f - maxFallSpeed;

						if (slowFall && velocity.Y < (0f - maxFallSpeed) / 3f && !TryingToHoverDown)
							velocity.Y = (0f - maxFallSpeed) / 3f;

						if (slowFall && velocity.Y < (0f - maxFallSpeed) / 5f && TryingToHoverUp)
							velocity.Y = (0f - maxFallSpeed) / 10f;
					}
				}
			}
		}
		else {
			UpdateControlHolds();
		}

		if (mount.Active)
			wingFrame = 0;

		if ((wingsLogic == 22 || wingsLogic == 28 || wingsLogic == 30 || wingsLogic == 31 || wingsLogic == 33 || wingsLogic == 35 || wingsLogic == 37 || wingsLogic == 45) && TryingToHoverDown && controlJump && wingTime > 0f && !merman) {
			float num71 = 0.9f;
			if (wingsLogic == 45)
				num71 = 0.8f;

			velocity.Y *= num71;
			if (velocity.Y > -2f && velocity.Y < 1f)
				velocity.Y = 1E-05f;
		}

		if (wingsLogic == 37 && TryingToHoverDown && controlJump && wingTime > 0f && !merman) {
			velocity.Y *= 0.92f;
			if (velocity.Y > -2f && velocity.Y < 1f)
				velocity.Y = 1E-05f;
		}

		GrabItems(i);
		LookForTileInteractions();
		if (tongued) {
			StopVanityActions();
			bool flag23 = false;
			if (Main.wofNPCIndex >= 0) {
				NPC nPC = Main.npc[Main.wofNPCIndex];
				float num72 = nPC.Center.X + (float)(nPC.direction * 200);
				float y7 = nPC.Center.Y;
				Vector2 center = base.Center;
				float num73 = num72 - center.X;
				float num74 = y7 - center.Y;
				float num75 = (float)Math.Sqrt(num73 * num73 + num74 * num74);
				float num76 = 11f;
				if (Main.expertMode) {
					float value = 22f;
					float amount = Math.Min(1f, nPC.velocity.Length() / 5f);
					num76 = MathHelper.Lerp(num76, value, amount);
				}

				float num77 = num75;
				if (num75 > num76) {
					num77 = num76 / num75;
				}
				else {
					num77 = 1f;
					flag23 = true;
				}

				num73 *= num77;
				num74 *= num77;
				velocity.X = num73;
				velocity.Y = num74;
			}
			else {
				flag23 = true;
			}

			if (flag23 && Main.myPlayer == whoAmI) {
				for (int num78 = 0; num78 < maxBuffs; num78++) {
					if (buffType[num78] == 38)
						DelBuff(num78);
				}
			}
		}

		if (Main.myPlayer == whoAmI) {
			WOFTongue();
			if (controlHook) {
				if (releaseHook)
					QuickGrapple();

				releaseHook = false;
			}
			else {
				releaseHook = true;
			}

			if (talkNPC >= 0) {
				Rectangle rectangle = new Rectangle((int)(position.X + (float)(width / 2) - (float)(tileRangeX * 16)), (int)(position.Y + (float)(height / 2) - (float)(tileRangeY * 16)), tileRangeX * 16 * 2, tileRangeY * 16 * 2);
				Rectangle value2 = new Rectangle((int)Main.npc[talkNPC].position.X, (int)Main.npc[talkNPC].position.Y, Main.npc[talkNPC].width, Main.npc[talkNPC].height);
				if (!rectangle.Intersects(value2) || chest != -1 || !Main.npc[talkNPC].active || tileEntityAnchor.InUse) {
					if (chest == -1)
						SoundEngine.PlaySound(11);

					SetTalkNPC(-1);
					Main.npcChatCornerItem = 0;
					Main.npcChatText = "";
				}
			}

			if (sign >= 0) {
				Rectangle value3 = new Rectangle((int)(position.X + (float)(width / 2) - (float)(tileRangeX * 16)), (int)(position.Y + (float)(height / 2) - (float)(tileRangeY * 16)), tileRangeX * 16 * 2, tileRangeY * 16 * 2);
				try {
					bool flag24 = false;
					if (Main.sign[sign] == null)
						flag24 = true;

					if (!flag24 && !new Rectangle(Main.sign[sign].x * 16, Main.sign[sign].y * 16, 32, 32).Intersects(value3))
						flag24 = true;

					if (flag24) {
						SoundEngine.PlaySound(11);
						sign = -1;
						Main.editSign = false;
						Main.npcChatText = "";
					}
				}
				catch {
					SoundEngine.PlaySound(11);
					sign = -1;
					Main.editSign = false;
					Main.npcChatText = "";
				}
			}

			if (Main.editSign) {
				if (sign == -1)
					Main.editSign = false;
				else
					Main.InputTextSign();
			}
			else if (Main.editChest) {
				Main.InputTextChest();
				if (Main.player[Main.myPlayer].chest == -1)
					Main.editChest = false;
			}

			if (mount.Active && mount.Cart && velocity.Length() > 4f) {
				Rectangle rectangle2 = new Rectangle((int)position.X, (int)position.Y, width, height);
				if (velocity.X < -1f)
					rectangle2.X -= 15;

				if (velocity.X > 1f)
					rectangle2.Width += 15;

				if (velocity.X < -10f)
					rectangle2.X -= 10;

				if (velocity.X > 10f)
					rectangle2.Width += 10;

				if (velocity.Y < -1f)
					rectangle2.Y -= 10;

				if (velocity.Y > 1f)
					rectangle2.Height += 10;

				for (int num79 = 0; num79 < 200; num79++) {
					if (Main.npc[num79].active && !Main.npc[num79].dontTakeDamage && !Main.npc[num79].friendly && Main.npc[num79].immune[i] == 0 && CanNPCBeHitByPlayerOrPlayerProjectile(Main.npc[num79]) && rectangle2.Intersects(new Rectangle((int)Main.npc[num79].position.X, (int)Main.npc[num79].position.Y, Main.npc[num79].width, Main.npc[num79].height))) {
						/*
						float num80 = meleeCrit;
						if (num80 < (float)rangedCrit)
							num80 = rangedCrit;

						if (num80 < (float)magicCrit)
							num80 = magicCrit;
						*/
						//TML: Potentially bad for performance
						float num80 = DamageClassLoader.DamageClasses.Select(t => GetTotalCritChance(t)).Max();

						bool crit = false;
						if ((float)Main.rand.Next(1, 101) <= num80)
							crit = true;

						float currentSpeed = velocity.Length() / maxRunSpeed;
						GetMinecartDamage(currentSpeed, out var damage2, out var knockback);
						int num81 = 1;
						if (velocity.X < 0f)
							num81 = -1;

						if (Main.npc[num79].knockBackResist < 1f && Main.npc[num79].knockBackResist > 0f)
							knockback /= Main.npc[num79].knockBackResist;

						if (whoAmI == Main.myPlayer)
							ApplyDamageToNPC(Main.npc[num79], damage2, knockback, num81, crit);

						Main.npc[num79].immune[i] = 30;
						if (!Main.npc[num79].active)
							AchievementsHelper.HandleSpecialEvent(this, 9);
					}
				}
			}

			Update_NPCCollision();
			if (!shimmering) {
				Collision.HurtTile hurtTile = GetHurtTile();
				if (hurtTile.type >= 0)
					ApplyTouchDamage(hurtTile.type, hurtTile.x, hurtTile.y);
			}

			TryToShimmerUnstuck();
		}

		if (controlRight) {
			releaseRight = false;
		}
		else {
			releaseRight = true;
			rightTimer = 7;
		}

		if (controlLeft) {
			releaseLeft = false;
		}
		else {
			releaseLeft = true;
			leftTimer = 7;
		}

		releaseDown = !controlDown;
		if (rightTimer > 0)
			rightTimer--;
		else if (controlRight)
			rightTimer = 7;

		if (leftTimer > 0)
			leftTimer--;
		else if (controlLeft)
			leftTimer = 7;

		GrappleMovement();
		StickyMovement();
		CheckDrowning();
		if (gravDir == -1f) {
			waterWalk = false;
			waterWalk2 = false;
		}

		int num82 = height;
		if (waterWalk)
			num82 -= 6;

		bool flag25 = false;
		if (!shimmering)
			flag25 = Collision.LavaCollision(position, width, num82);

		if (flag25) {
			if (!lavaImmune && Main.myPlayer == i && hurtCooldowns[4] <= 0) {
				if (lavaTime > 0) {
					lavaTime--;
				}
				else {
					int num83 = 80;
					int num84 = 420;
					if (Main.remixWorld) {
						num83 = 200;
						num84 = 630;
					}

					if (!ashWoodBonus || !lavaRose) {
						if (ashWoodBonus) {
							if (Main.remixWorld)
								num83 = 145;

							num83 /= 2;
							num84 -= 210;
						}

						if (lavaRose) {
							num83 -= 45;
							num84 -= 210;
						}

						if (num83 > 0)
							Hurt(PlayerDeathReason.ByOther(2), num83, 0, pvp: false, quiet: false, Crit: false, 4);

						if (num84 > 0)
							AddBuff(24, num84);
					}
				}
			}

			lavaWet = true;
		}
		else {
			lavaWet = false;
			if (lavaTime < lavaMax)
				lavaTime++;
		}

		if (lavaTime > lavaMax)
			lavaTime = lavaMax;

		if (waterWalk2 && !waterWalk)
			num82 -= 6;

		bool num85 = Collision.WetCollision(position, width, height);
		bool flag26 = Collision.honey;
		bool shimmer = Collision.shimmer;
		if (shimmer) {
			shimmerWet = true;
			if (whoAmI == Main.myPlayer && !shimmerImmune && !shimmerUnstuckHelper.ShouldUnstuck) {
				int num86 = (int)(base.Center.X / 16f);
				int num87 = (int)((position.Y + 1f) / 16f);
				if (Main.tile[num86, num87] != null && Main.tile[num86, num87].shimmer() && Main.tile[num86, num87].liquid >= 0 && position.Y / 16f < (float)Main.UnderworldLayer)
					AddBuff(353, 60);
			}
		}

		if (flag26 && !shimmering) {
			AddBuff(48, 1800);
			honeyWet = true;
		}

		if (num85) {
			if ((onFire || onFire3) && !lavaWet) {
				for (int num88 = 0; num88 < maxBuffs; num88++) {
					int num89 = buffType[num88];
					if (num89 == 24 || num89 == 323)
						DelBuff(num88);
				}
			}

			if (!wet) {
				if (wetCount == 0) {
					wetCount = 10;
					if (!shimmering) {
						if (!flag25) {
							if (shimmerWet) {
								for (int num90 = 0; num90 < 50; num90++) {
									int num91 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2)), width + 12, 24, 308);
									Main.dust[num91].velocity.Y -= 4f;
									Main.dust[num91].velocity.X *= 2.5f;
									Main.dust[num91].scale = 0.8f;
									Main.dust[num91].noGravity = true;
									switch (Main.rand.Next(6)) {
										case 0:
											Main.dust[num91].color = new Color(255, 255, 210);
											break;
										case 1:
											Main.dust[num91].color = new Color(190, 245, 255);
											break;
										case 2:
											Main.dust[num91].color = new Color(255, 150, 255);
											break;
										default:
											Main.dust[num91].color = new Color(190, 175, 255);
											break;
									}
								}

								SoundEngine.PlaySound(19, (int)position.X, (int)position.Y, 2);
							}
							else if (honeyWet) {
								for (int num92 = 0; num92 < 20; num92++) {
									int num93 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2) - 8f), width + 12, 24, 152);
									Main.dust[num93].velocity.Y -= 1f;
									Main.dust[num93].velocity.X *= 2.5f;
									Main.dust[num93].scale = 1.3f;
									Main.dust[num93].alpha = 100;
									Main.dust[num93].noGravity = true;
								}

								SoundEngine.PlaySound(19, (int)position.X, (int)position.Y);
							}
							else {
								for (int num94 = 0; num94 < 50; num94++) {
									int num95 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2) - 8f), width + 12, 24, Dust.dustWater());
									Main.dust[num95].velocity.Y -= 3f;
									Main.dust[num95].velocity.X *= 2.5f;
									Main.dust[num95].scale = 0.8f;
									Main.dust[num95].alpha = 100;
									Main.dust[num95].noGravity = true;
								}

								SoundEngine.PlaySound(19, (int)position.X, (int)position.Y, 0);
							}
						}
						else {
							for (int num96 = 0; num96 < 20; num96++) {
								int num97 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2) - 8f), width + 12, 24, 35);
								Main.dust[num97].velocity.Y -= 1.5f;
								Main.dust[num97].velocity.X *= 2.5f;
								Main.dust[num97].scale = 1.3f;
								Main.dust[num97].alpha = 100;
								Main.dust[num97].noGravity = true;
							}

							SoundEngine.PlaySound(19, (int)position.X, (int)position.Y);
						}
					}
				}

				wet = true;
				if (ShouldFloatInWater) {
					velocity.Y /= 2f;
					if (velocity.Y > 3f)
						velocity.Y = 3f;
				}
			}
		}
		else if (wet) {
			wet = false;
			if (jump > jumpHeight / 5 && wetSlime == 0)
				jump = jumpHeight / 5;

			if (wetCount == 0) {
				wetCount = 10;
				if (!shimmering) {
					if (!lavaWet) {
						if (shimmerWet) {
							for (int num98 = 0; num98 < 50; num98++) {
								int num99 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2)), width + 12, 24, 308);
								Main.dust[num99].velocity.Y -= 4f;
								Main.dust[num99].velocity.X *= 2.5f;
								Main.dust[num99].scale = 0.75f;
								Main.dust[num99].noGravity = true;
								switch (Main.rand.Next(6)) {
									case 0:
										Main.dust[num99].color = new Color(255, 255, 210);
										break;
									case 1:
										Main.dust[num99].color = new Color(190, 245, 255);
										break;
									case 2:
										Main.dust[num99].color = new Color(255, 150, 255);
										break;
									default:
										Main.dust[num99].color = new Color(190, 175, 255);
										break;
								}
							}

							SoundEngine.PlaySound(19, (int)position.X, (int)position.Y, 3);
						}
						else if (honeyWet) {
							for (int num100 = 0; num100 < 20; num100++) {
								int num101 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2) - 8f), width + 12, 24, 152);
								Main.dust[num101].velocity.Y -= 1f;
								Main.dust[num101].velocity.X *= 2.5f;
								Main.dust[num101].scale = 1.3f;
								Main.dust[num101].alpha = 100;
								Main.dust[num101].noGravity = true;
							}

							SoundEngine.PlaySound(19, (int)position.X, (int)position.Y);
						}
						else {
							for (int num102 = 0; num102 < 50; num102++) {
								int num103 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2)), width + 12, 24, Dust.dustWater());
								Main.dust[num103].velocity.Y -= 4f;
								Main.dust[num103].velocity.X *= 2.5f;
								Main.dust[num103].scale = 0.8f;
								Main.dust[num103].alpha = 100;
								Main.dust[num103].noGravity = true;
							}

							SoundEngine.PlaySound(19, (int)position.X, (int)position.Y, 0);
						}
					}
					else {
						for (int num104 = 0; num104 < 20; num104++) {
							int num105 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (float)(height / 2) - 8f), width + 12, 24, 35);
							Main.dust[num105].velocity.Y -= 1.5f;
							Main.dust[num105].velocity.X *= 2.5f;
							Main.dust[num105].scale = 1.3f;
							Main.dust[num105].alpha = 100;
							Main.dust[num105].noGravity = true;
						}

						SoundEngine.PlaySound(19, (int)position.X, (int)position.Y);
					}
				}
			}
		}

		if (!flag26)
			honeyWet = false;

		if (!shimmer)
			shimmerWet = false;

		if (!wet) {
			lavaWet = false;
			honeyWet = false;
			shimmerWet = false;
		}

		if (wetCount > 0)
			wetCount--;

		if (wetSlime > 0)
			wetSlime--;

		if (wet && mount.Active) {
			switch (mount.Type) {
				case 5:
				case 7:
					if (whoAmI == Main.myPlayer)
						mount.Dismount(this);
					break;
				case 3:
				case 50:
					wetSlime = 30;
					if (velocity.Y > 2f)
						velocity.Y *= 0.9f;
					velocity.Y -= 0.5f;
					if (velocity.Y < -4f)
						velocity.Y = -4f;
					break;
			}
		}

		if (Main.expertMode && ZoneSnow && wet && !lavaWet && !honeyWet && !arcticDivingGear && environmentBuffImmunityTimer == 0)
			AddBuff(46, 150);

		float num106 = 1f + Math.Abs(velocity.X) / 3f;
		if (gfxOffY > 0f) {
			gfxOffY -= num106 * stepSpeed;
			if (gfxOffY < 0f)
				gfxOffY = 0f;
		}
		else if (gfxOffY < 0f) {
			gfxOffY += num106 * stepSpeed;
			if (gfxOffY > 0f)
				gfxOffY = 0f;
		}

		if (gfxOffY > 32f)
			gfxOffY = 32f;

		if (gfxOffY < -32f)
			gfxOffY = -32f;

		if (Main.myPlayer == i) {
			if (!iceSkate)
				CheckIceBreak();

			CheckCrackedBrickBreak();
		}

		if (!shimmering) {
			SlopeDownMovement();
			bool flag27 = mount.Type == 7 || mount.Type == 8 || mount.Type == 12 || mount.Type == 44 || mount.Type == 49;
			if (velocity.Y == gravity && (!mount.Active || (!mount.Cart && mount.Type != 48 && !flag27)))
				Collision.StepDown(ref position, ref velocity, width, height, ref stepSpeed, ref gfxOffY, (int)gravDir, waterWalk || waterWalk2);

			if (gravDir == -1f) {
				if ((carpetFrame != -1 || velocity.Y <= gravity) && !controlUp)
					Collision.StepUp(ref position, ref velocity, width, height, ref stepSpeed, ref gfxOffY, (int)gravDir, controlUp);
			}
			else if ((carpetFrame != -1 || velocity.Y >= gravity) && !controlDown && !mount.Cart && !flag27 && grappling[0] == -1) {
				Collision.StepUp(ref position, ref velocity, width, height, ref stepSpeed, ref gfxOffY, (int)gravDir, controlUp);
			}
		}

		oldPosition = position;
		oldDirection = direction;
		bool falling = false;
		if (velocity.Y > gravity)
			falling = true;

		if (velocity.Y < 0f - gravity)
			falling = true;

		Vector2 vector3 = velocity;
		slideDir = 0;
		bool ignorePlats = false;
		bool fallThrough = controlDown;
		if ((gravDir == -1f) | (mount.Active && (mount.Cart || mount.Type == 12 || mount.Type == 7 || mount.Type == 8 || mount.Type == 23 || mount.Type == 44 || mount.Type == 48)) | GoingDownWithGrapple | pulley) {
			ignorePlats = true;
			fallThrough = true;
		}

		bool flag28 = onTrack;
		onTrack = false;
		bool flag29 = false;
		if (mount.Active && mount.Cart) {
			fartKartCloudDelay = Math.Max(0, fartKartCloudDelay - 1);
			float num107 = ((ignoreWater || merman) ? 1f : (shimmerWet ? 0.25f : (honeyWet ? 0.25f : ((!wet) ? 1f : 0.5f))));
			velocity *= num107;
			DelegateMethods.Minecart.rotation = fullRotation;
			DelegateMethods.Minecart.rotationOrigin = fullRotationOrigin;
			BitsByte bitsByte = Minecart.TrackCollision(this, ref position, ref velocity, ref lastBoost, width, height, controlDown, controlUp, fallStart2, trackOnly: false, mount.Delegations);
			if (bitsByte[0]) {
				onTrack = true;
				gfxOffY = Minecart.TrackRotation(this, ref fullRotation, position + velocity, width, height, controlDown, controlUp, mount.Delegations);
				fullRotationOrigin = new Vector2(width / 2, height);
			}

			if (flag28 && !onTrack)
				mount.Delegations.MinecartJumpingSound(this, position, width, height);

			if (bitsByte[1]) {
				if (controlLeft || controlRight) {
					if (cartFlip)
						cartFlip = false;
					else
						cartFlip = true;
				}

				if (velocity.X > 0f)
					direction = 1;
				else if (velocity.X < 0f)
					direction = -1;

				mount.Delegations.MinecartBumperSound(this, position, width, height);
			}

			velocity /= num107;
			if (bitsByte[3] && whoAmI == Main.myPlayer)
				flag29 = true;

			if (bitsByte[2])
				cartRampTime = (int)(Math.Abs(velocity.X) / mount.RunSpeed * 20f);

			if (bitsByte[4])
				trackBoost -= 4f;

			if (bitsByte[5])
				trackBoost += 4f;
		}

		bool flag30 = whoAmI == Main.myPlayer && !mount.Active;
		Vector2 vector4 = position;
		if (vortexDebuff)
			velocity.Y = velocity.Y * 0.8f + (float)Math.Cos(base.Center.X % 120f / 120f * ((float)Math.PI * 2f)) * 5f * 0.2f;

		PlayerLoader.PreUpdateMovement(this);

		if (tongued) {
			position += velocity;
			flag30 = false;
		}
		else if (shimmerWet || shimmering) {
			ShimmerCollision(fallThrough, ignorePlats, shimmering);
		}
		else if (honeyWet && !ignoreWater) {
			HoneyCollision(fallThrough, ignorePlats);
		}
		else if (wet && !merman && !ignoreWater && !trident) {
			WaterCollision(fallThrough, ignorePlats);
		}
		else {
			DryCollision(fallThrough, ignorePlats);
			if (mount.Active && mount.IsConsideredASlimeMount && velocity.Y != 0f && !SlimeDontHyperJump) {
				Vector2 vector5 = velocity;
				velocity.X = 0f;
				DryCollision(fallThrough, ignorePlats);
				velocity.X = vector5.X;
			}

			if (mount.Active && mount.Type == 43 && velocity.Y != 0f) {
				Vector2 vector6 = velocity;
				velocity.X = 0f;
				DryCollision(fallThrough, ignorePlats);
				velocity.X = vector6.X;
			}
		}

		UpdateTouchingTiles();
		TryBouncingBlocks(falling);
		TryLandingOnDetonator();
		if (!shimmering && !tongued) {
			SlopingCollision(fallThrough, ignorePlats);
			if (!isLockedToATile)
				Collision.StepConveyorBelt(this, gravDir);
		}

		if (flag30 && velocity.Y == 0f)
			AchievementsHelper.HandleRunning(Math.Abs(position.X - vector4.X));

		if (flag29) {
			NetMessage.SendData(13, -1, -1, null, whoAmI);
			Minecart.HitTrackSwitch(new Vector2(position.X, position.Y), width, height);
		}

		if (vector3.X != velocity.X) {
			if (vector3.X < 0f)
				slideDir = -1;
			else if (vector3.X > 0f)
				slideDir = 1;
		}

		if (gravDir == 1f && Collision.up) {
			velocity.Y = 0.01f;
			if (!merman)
				jump = 0;
		}
		else if (gravDir == -1f && Collision.down) {
			velocity.Y = -0.01f;
			if (!merman)
				jump = 0;
		}

		if (velocity.Y == 0f && grappling[0] == -1)
			FloorVisuals(falling);

		if (whoAmI == Main.myPlayer && !shimmering)
			Collision.SwitchTiles(position, width, height, oldPosition, 1);

		PressurePlateHelper.UpdatePlayerPosition(this);
		BordersMovement();
		numMinions = 0;
		slotsMinions = 0f;
		if (Main.netMode != 2 && mount.Type != 8)
			ItemCheck_ManageRightClickFeatures();

		ItemCheckWrapped(i);
		PlayerFrame();
		if (mount.Type == 8)
			mount.UseDrill(this);

		if (statLife > statLifeMax2)
			statLife = statLifeMax2;

		if (statMana > statManaMax2)
			statMana = statManaMax2;

		if (breath > breathMax)
			breath = breathMax;
		// More patch context.
		grappling[0] = -1;
		grapCount = 0;
		UpdateReleaseUseTile();
		UpdateAdvancedShadows();

		PlayerLoader.PostUpdate(this);
	}
```