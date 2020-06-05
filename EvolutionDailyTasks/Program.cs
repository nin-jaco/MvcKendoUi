using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "LogSettings.xml", Watch = true)]


namespace EvolutionDailyTasks
{
    class Program
    {
        protected readonly static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            //// This main sub procedure will contain the list of things to do whenever it runs. It should run once a day.
            //// The main sub should contain no logic itself, just calls to other functions in other classes inside the EvolutionDailyTasks app. Those other functions can call the business logic layer.
            //// The idea is that this app can write exception details to the screen, even write to the console. 
            //// DO NOT WRITE TO THE CONSOLE FROM THE BUSINESS LOGIC LAYER!!!! Only do so from code within this console app.

            //log.Info("Starting up Evolution Daily Tasks - " + DateTime.Now.ToLongTimeString());
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Starting up..." + DateTime.Now.ToLongTimeString());
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Gray;

            ////bool IsDailyTask = false;

            //if (args.Any(q => q.ToLower() == "?"))
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Available parameters:");
            //    Console.WriteLine();

            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("ResetAttributeEncryption");
            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    Console.WriteLine("Description: Resets Attribute Encryption, based on IsSensitive setting in Attribute Library. Takes about 5-10 minutes.");
            //    Console.WriteLine();


            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("ResendAllActiveEngagements");
            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    Console.WriteLine("Description: Resends all currently ACTIVE engagements to the IDV");
            //    Console.WriteLine();

            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("Daily");
            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    Console.WriteLine("Description: Runs all the Evolution operations that should just run once daily");
            //    Console.WriteLine();

            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("<No Parameters>");
            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    Console.WriteLine("Description: Runs all the Evolution operations that should just often - typically every 5 minutes.");
            //    Console.WriteLine();

            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    return;
            //}

            //if (args.Any(q => q.ToLower() == "resetattributeencryption"))
            //{
            //    try
            //    {
            //        Console.WriteLine("Resetting Attribute Encryption, based on IsSensitive setting in Attribute Library");
            //        EvolutionBusinessLogic.Core.EvolutionEncryption.GetCrypto().resetAttributeEncryption();
            //        EvolutionBusinessLogic.Core.EvolutionEncryption.GetCrypto().resetIdentityProperCase();                    
            //    }
            //    catch (Exception ex)
            //    {
            //        log.Error("Reset Attribute Encryption Error:", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    Console.WriteLine();
            //    log.Info("Shutting down Evolution Daily Tasks" + DateTime.Now.ToLongTimeString());
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("Shutting down..." + DateTime.Now.ToLongTimeString());
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    return;
            //}

            //if (args.Any(q => q.ToLower() == "resendallactiveengagements"))
            //{
            //    try
            //    {
            //        Console.WriteLine("Resends all currently ACTIVE engagements to the IDV");
            //        EvolutionDailyTasks.VodacomIDM.ResendActiveEngagements();
            //    }
            //    catch (Exception ex)
            //    {
            //        log.Error("Resends all currently ACTIVE engagements to the IDV Error:", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    Console.WriteLine();
            //    log.Info("Shutting down Evolution Daily Tasks" + DateTime.Now.ToLongTimeString());
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("Shutting down..." + DateTime.Now.ToLongTimeString());
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    return;
            //}

            //if (args.Any(q => q.ToLower() == "daily")) //Do this daily
            //{
            //    try
            //    {
            //        Console.WriteLine("Approval tasks that are due to expire");
            //        ApprovalReminders.GetAndSendDueApprovalTaskRemindersPerApprover();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished sending notifications for approval tasks that are due to expire to their approvers");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
                
            //    try
            //    {
            //        Console.WriteLine("Expiring contracts that are due to expire");
            //        EndingEngagements.SendNotificationForExpiredContracts();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished sending notifications for contracts that are due to expire to their sponsors");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    // RetireEngagementsForNowPermanentEmployees
            //    try
            //    {
            //        Console.WriteLine("Terminate Engagements For Now Permanent Employees");
            //        EndingEngagements.RetireEngagementsForNowPermanentEmployees();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished sending notifications for contracts that are due to expire to their sponsors");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex)
            //    {
            //        log.Error("Error in RetireEngagementsForNowPermanentEmployees: ", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }


            //}
            //else if (args.Any(q => q.ToLower() == "4pm")) //Do this at 4pm
            //{
            //    try
            //    {
            //        Console.WriteLine("Visitors with no end at 4pm");
            //        Visitors.VisitorNoEndDate(EvolutionBusinessLogic.Enumeration.VisitorNoEndDate.NoEndDateToPersonVisited4pm);
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished sending notifications for visitors with no end at 4pm");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //}
            //else if (args.Any(q => q.ToLower() == "5pm")) //Do this at 5pm
            //{
            //    try
            //    {
            //        Console.WriteLine("Visitors with no end at 5pm");
            //        Visitors.VisitorNoEndDate(EvolutionBusinessLogic.Enumeration.VisitorNoEndDate.NoEndDateToPersonVisited5pm);
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished sending notifications for visitors with no end at 5pm");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //}
            //else if (args.Any(q => q.ToLower() == "6pm")) //Do this at 6pm
            //{
            //    try
            //    {
            //        Console.WriteLine("Visitors with no end at 6pm");
            //        Visitors.VisitorNoEndDate(EvolutionBusinessLogic.Enumeration.VisitorNoEndDate.NoEndDateToSecuritySpecialist6pm);
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished sending notifications for visitors with no end at 6pm");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //}
            //else if (args.Any(q => q.ToLower() == "12am")) //Do this at 12am
            //{
            //    try
            //    {
            //        Console.WriteLine("Visitors with no end at 12am");
            //        Visitors.VisitorNoEndDate(EvolutionBusinessLogic.Enumeration.VisitorNoEndDate.NoEndDateToSecuritySpecialist12am);
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished sending notifications for visitors with no end at 12am");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //}
            //else //Do this every 5 mins.
            //{
            //    try
            //    {

            //        Console.WriteLine("Expiring Approvals that is past their due date");
            //        int tasksExpired = EvolutionDailyTasks.ExpiringApprovals.ApprovalsSetToExpire();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("# of Approvals that expired: " + tasksExpired.ToString());
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    //Important: It is important to first do EngagementsToBecomeInactive, before EngagementsToBecomeActive.
            //    //      Why: If an individual has 2 engagements, one becoming active the next day after another ended, we must first make the ending one inactive before making the new one active.
            //    try
            //    {
            //        Console.WriteLine("Engagements that are due to become inactive, which include engagements awaiting termination and suspension");
            //        int engagementsDeactivated = EvolutionDailyTasks.EndingEngagements.EngagementsToBecomeInactive();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("# of Engagements that were deactivated: " + engagementsDeactivated.ToString());
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    try
            //    {
            //        Console.WriteLine("Engagements that are due to become active");
            //        int engagementsActivated = EvolutionDailyTasks.StartingEngagements.EngagementsToBecomeActive();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("# of Engagements that were activated: " + engagementsActivated.ToString());
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    try
            //    {
            //        Console.WriteLine("Repeating failed WebService calls to Vodacom IDM");
            //        VodacomIDM.RetryFailedWSCalls();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished re-sending WS calls.");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
                 
            //    try
            //    {
            //        Console.WriteLine("Deleting unused draft engagement instances.");
            //        DeleteEngagement.DeleteUnusedDraftEngagements();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished deleting unused draft engagement instances.");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex)
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    try
            //    {
            //        Console.WriteLine("Deleting inactive visitor engagement instances.");
            //        DeleteVisitorEngagement.DeleteInactiveVisitorEngagements();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished deleting inactive visitor engagement instances.");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex)
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    try
            //    {
            //        Console.WriteLine("Recording daily statistics.");
            //        EvolutionBusinessLogic.Utilities.Statistics.RecordEngagementStatisticsPerDay();
            //    }
            //    catch (Exception ex)
            //    {
            //        log.Error("General Error while recording statistics. ", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    try
            //    {
            //        Console.WriteLine("Processing Review Campaigns");
            //        ReviewCampaigns.ProcessDailyReviewCampaigns();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished processing Review Campaigns.");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    // CleanUpOrphanedApprovalTasks
            //    try
            //    {
            //        Console.WriteLine("Cleaning up Orphaned ApprovalTasks");
            //        EvolutionBusinessLogic.Approval.ApprovalLogic.CleanUpOrphanedApprovalTasks();
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("Finished Cleaning up Orphaned ApprovalTasks.");
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    catch (Exception ex) // This is the top-most catch that stops the app from crashing if an exception occurs.
            //    {
            //        log.Error("General Error", ex);
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine();
            //        Console.WriteLine(ex.Message);
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //}

            //log.Info("Shutting down Evolution Daily Tasks" + DateTime.Now.ToLongTimeString());
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Shutting down..." + DateTime.Now.ToLongTimeString());
            //Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }
}
