using Exercise_07;

Console.WriteLine("Proving learning from AB02-B...");

using var context = new Context();

// Create group
var group = new Group("Admins");
context.Add(group);
context.SaveChanges();

// Show group name from context
group = context.Groups.First();
Console.WriteLine("Group name: {0}", group.Name);

// Update group 
group.Name = "Administrators";
context.SaveChanges();

// Show group name from context
group = context.Groups.First();
Console.WriteLine("Group name: {0}", group.Name);

// Create User
var user = new User("max@test.ch", "Max", "Mustermann") { Salutation = "Herr" };
context.Add(user);
context.SaveChanges();

// Show user from context
user = context.Users.First();
Console.WriteLine("User named: {0} {1}", user.Firstname, user.Lastname);

// Update User
user.Lastname = "Musterfrau";
context.SaveChanges();

// Show user from context
user = context.Users.First();
Console.WriteLine("User named: {0} {1}", user.Firstname, user.Lastname);

// Add User to Group
group.Users.Add(user);
context.SaveChanges();

// Show group users
var groupUsers = group.Users.ToList();
Console.WriteLine("The following users are in the group named {0}:", group.Name);
foreach (var groupUser in groupUsers)
{
    Console.WriteLine("{0} {1}", groupUser.Firstname, groupUser.Lastname);
}

// Add Permission
var permission = new Permission("Deleting things", "DEL-T");
context.Add(permission);
context.SaveChanges();

// Show permission from context
permission = context.Permissions.First();
Console.WriteLine("Permission Name: {0}", permission.Name);

// Update Permission
permission.Name = "Delete Objects";
permission.Codename = "DEL-OBJ";
context.SaveChanges();

// Show permission from context
permission = context.Permissions.First();
Console.WriteLine("Permission Name: {0}", permission.Name);

// Give Permission to Group
group.Permissions.Add(permission);
context.SaveChanges();

// Show group permissions
var groupPermissions = group.Permissions.ToList();
Console.WriteLine("The following permissions are in the group namend {0}:", group.Name);
foreach (var groupPermission in groupPermissions)
{
    Console.WriteLine("Name: {0}, Codename: {1}", groupPermission.Name, groupPermission.Codename);
}

// Delete User
context.Users.Remove(user);
context.SaveChanges();

// Show amount of users in context
var users = context.Users.ToList();
Console.WriteLine("Amount of users: {0}", users.Count);

// Delete Permission
context.Permissions.Remove(permission);
context.SaveChanges();

// Show amount of permissions in context
var permissions = context.Permissions.ToList();
Console.WriteLine("Amount of permissions: {0}", permissions.Count);

// Delete Group
context.Groups.Remove(group);
context.SaveChanges();

// show amount of groups in context
var groups = context.Groups.ToList();
Console.WriteLine("Amount of groups: {0}", groups.Count);