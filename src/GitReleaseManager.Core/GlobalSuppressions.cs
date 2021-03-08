// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Code Analysis results, point to "Suppress Message", and click
// "In Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly", Justification = "This was in relation to the Information Version Number generated by GitVersion, which we want to leave as is.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "GitReleaseManager.Core.Helpers", Justification = "Still being worked on")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Wrong Usage", "DF0033:Marks undisposed objects assinged to a property, originated from a method invocation.", Justification = "This is being handled later in the code", Scope = "member", Target = "~M:GitReleaseManager.Core.GitHubProvider.AddAssets(System.String,System.String,System.String,System.Collections.Generic.IList{System.String})~System.Threading.Tasks.Task")]