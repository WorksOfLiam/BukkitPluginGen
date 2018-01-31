package com.{PackageName}.mod;

import java.util.HashMap;

import org.bukkit.entity.Player;
import org.bukkit.plugin.PluginManager;
import org.bukkit.plugin.java.JavaPlugin;

import com.mydude.mod.Commands.DebugCommand;
import com.mydude.mod.Commands.PosCommand;
import com.mydude.mod.Listeners.BlockListener;
import com.mydude.mod.Listeners.PlayerListener;

public class {PluginName} extends JavaPlugin {
	private final PlayerListener playerListener = new PlayerListener(this);
    private final BlockListener blockListener = new BlockListener();
    private final HashMap<Player, Boolean> debugees = new HashMap<Player, Boolean>();
	
	@Override
	public void onEnable() {
		getLogger().info("onEnable has been invoked!");
		
		//Add seperate listeners here
		PluginManager pm = getServer().getPluginManager();
        pm.registerEvents(playerListener, this);
        pm.registerEvents(blockListener, this);
        
		//Register commands here AND in plugins.yml.
        getCommand("pos").setExecutor(new PosCommand());
        getCommand("debug").setExecutor(new DebugCommand(this));
	}

	@Override
	public void onDisable() {
		getLogger().info("onDisable has been invoked!");
	}
	
    public boolean isPlayerDebugging(final Player player) {
        if (debugees.containsKey(player)) {
            return debugees.get(player);
        } else {
            return false;
        }
    }

    public void setPlayerDebugging(final Player player, final boolean value) {
        debugees.put(player, value);
    }
}
