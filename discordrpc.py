from pypresence import Presence
import time

client_id = "953316205001842718"
RPC = Presence(client_id)

RPC.connect()

RPC.update(state="Neoblox is made by Plextora#0033", details="Exploiting in Roblox using Neoblox", large_image="neoblox-icon")

while True:
    time.sleep(3)
