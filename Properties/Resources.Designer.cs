﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BukkitPluginGen.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BukkitPluginGen.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package com.{PackageName}.mod.Listeners;
        ///
        ///import org.bukkit.Material;
        ///import org.bukkit.block.Block;
        ///import org.bukkit.block.BlockFace;
        ///import org.bukkit.event.EventHandler;
        ///import org.bukkit.event.Listener;
        ///import org.bukkit.event.block.BlockCanBuildEvent;
        ///import org.bukkit.event.block.BlockPhysicsEvent;
        ///
        ///public class BlockListener implements Listener {
        ///    @EventHandler
        ///    public void onBlockPhysics(BlockPhysicsEvent event) {
        ///        Block block = event.getBlock();
        ///
        ///        if ((block.getT [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BlockListener {
            get {
                return ResourceManager.GetString("BlockListener", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;classpath&gt;
        ///	&lt;classpathentry kind=&quot;src&quot; output=&quot;target/classes&quot; path=&quot;src/main/java&quot;&gt;
        ///		&lt;attributes&gt;
        ///			&lt;attribute name=&quot;optional&quot; value=&quot;true&quot;/&gt;
        ///			&lt;attribute name=&quot;maven.pomderived&quot; value=&quot;true&quot;/&gt;
        ///		&lt;/attributes&gt;
        ///	&lt;/classpathentry&gt;
        ///	&lt;classpathentry excluding=&quot;**&quot; kind=&quot;src&quot; output=&quot;target/classes&quot; path=&quot;src/main/resources&quot;&gt;
        ///		&lt;attributes&gt;
        ///			&lt;attribute name=&quot;maven.pomderived&quot; value=&quot;true&quot;/&gt;
        ///		&lt;/attributes&gt;
        ///	&lt;/classpathentry&gt;
        ///	&lt;classpathentry kind=&quot;src&quot; o [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string classpath {
            get {
                return ResourceManager.GetString("classpath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package com.{PackageName}.mod.Commands;
        ///
        ///import org.bukkit.command.Command;
        ///import org.bukkit.command.CommandExecutor;
        ///import org.bukkit.command.CommandSender;
        ///import org.bukkit.entity.Player;
        ///
        ///import com.{PackageName}.mod.{PluginName};
        ///
        ///public class DebugCommand implements CommandExecutor {
        ///    private final {PluginName} plugin;
        ///
        ///    public DebugCommand({PluginName} plugin) {
        ///        this.plugin = plugin;
        ///    }
        ///
        ///    public boolean onCommand(CommandSender sender, Command command, String labe [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DebugCommand {
            get {
                return ResourceManager.GetString("DebugCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package com.{PackageName}.mod;
        ///
        ///import org.bukkit.plugin.java.JavaPlugin;
        ///
        ///public class {PluginName} extends JavaPlugin {
        ///	private final PlayerListener playerListener = new PlayerListener(this);
        ///    private final BlockListener blockListener = new BlockListener();
        ///    private final HashMap&lt;Player, Boolean&gt; debugees = new HashMap&lt;Player, Boolean&gt;();
        ///	
        ///	@Override
        ///	public void onEnable() {
        ///		getLogger().info(&quot;onEnable has been invoked!&quot;);
        ///		
        ///		//Add seperate listeners here
        ///		PluginManager pm = get [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MainClass {
            get {
                return ResourceManager.GetString("MainClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package com.{PackageName}.mod.Listeners;
        ///
        ///import org.bukkit.Location;
        ///import org.bukkit.event.EventHandler;
        ///import org.bukkit.event.Listener;
        ///import org.bukkit.event.player.PlayerJoinEvent;
        ///import org.bukkit.event.player.PlayerMoveEvent;
        ///import org.bukkit.event.player.PlayerQuitEvent;
        ///
        ///import com.{PackageName}.mod.{PluginName};
        ///
        ///public class PlayerListener implements Listener {
        ///    private final {PluginName} plugin;
        ///
        ///    public PlayerListener({PluginName} instance) {
        ///        plugin = instance [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PlayerListener {
            get {
                return ResourceManager.GetString("PlayerListener", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to name: {PluginName}
        ///main: com.{PackageName}.mod.{PluginName}
        ///version: 1.0.0.
        /// </summary>
        internal static string plugin {
            get {
                return ResourceManager.GetString("plugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;project xmlns=&quot;http://maven.apache.org/POM/4.0.0&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xsi:schemaLocation=&quot;http://maven.apache.org/POM/4.0.0 http://maven.apache.org/xsd/maven-4.0.0.xsd&quot;&gt;
        ///  &lt;modelVersion&gt;4.0.0&lt;/modelVersion&gt;
        ///  &lt;groupId&gt;com.{PackageName}.mod&lt;/groupId&gt;
        ///  &lt;artifactId&gt;{PluginName}&lt;/artifactId&gt;
        ///  &lt;version&gt;0.0.1-SNAPSHOT&lt;/version&gt;
        ///  &lt;build&gt;
        ///    &lt;plugins&gt;
        ///      &lt;plugin&gt;
        ///        &lt;groupId&gt;org.apache.maven.plugins&lt;/groupId&gt;
        ///        &lt;artifactId&gt;maven-compiler-plugin&lt;/artifact [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string pom {
            get {
                return ResourceManager.GetString("pom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package com.{PackageName}.mod.Commands;
        ///
        ///import org.bukkit.Location;
        ///import org.bukkit.command.Command;
        ///import org.bukkit.command.CommandExecutor;
        ///import org.bukkit.command.CommandSender;
        ///import org.bukkit.entity.Player;
        ///
        ///public class PosCommand implements CommandExecutor {
        ///    public boolean onCommand(CommandSender sender, Command command, String label, String[] split) {
        ///        if (!(sender instanceof Player)) {
        ///            return false;
        ///        }
        ///        Player player = (Player) sender;
        ///
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PosCommand {
            get {
                return ResourceManager.GetString("PosCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;projectDescription&gt;
        ///	&lt;name&gt;{PluginName}&lt;/name&gt;
        ///	&lt;comment&gt;&lt;/comment&gt;
        ///	&lt;projects&gt;
        ///	&lt;/projects&gt;
        ///	&lt;buildSpec&gt;
        ///		&lt;buildCommand&gt;
        ///			&lt;name&gt;org.eclipse.jdt.core.javabuilder&lt;/name&gt;
        ///			&lt;arguments&gt;
        ///			&lt;/arguments&gt;
        ///		&lt;/buildCommand&gt;
        ///		&lt;buildCommand&gt;
        ///			&lt;name&gt;org.eclipse.m2e.core.maven2Builder&lt;/name&gt;
        ///			&lt;arguments&gt;
        ///			&lt;/arguments&gt;
        ///		&lt;/buildCommand&gt;
        ///	&lt;/buildSpec&gt;
        ///	&lt;natures&gt;
        ///		&lt;nature&gt;org.eclipse.jdt.core.javanature&lt;/nature&gt;
        ///		&lt;nature&gt;org.eclipse.m2e.core.maven2N [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string project {
            get {
                return ResourceManager.GetString("project", resourceCulture);
            }
        }
    }
}
