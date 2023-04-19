




































EXTERNAL changeBackground(background)
->  TeachersHome

=== TeachersHome ===
~changeBackground(3)
Gloria: Emily are you ready for school?
Emily: Yes mom I’ve got everything I need.
Gloria: Alright, can you make your way to the school bus? I’m running late for work.
Emily: No worries, I can make it there. Have a good day at work mom. Love you!
Gloria: Alright thanks honey, love you too. Have a good day at school.
-> TeachersCar

=== TeachersCar ===
~changeBackground(0)
Gloria(H): I hope Emily has an easier time with fractions soon,
Gloria(H): I might have to…


~changeBackground(1)
Gloria has found themselves in a situation in which will change their day-to-day life for ever.
They were in pain after the accident and, because of their busy schedule, finally visits a walk-in clinic.
-> DoctorsRoom1

=== DoctorsRoom1 ===
~changeBackground(2)
Gloria(S): Hi Doctor, even though it’s been a while after the accident I still have pain in my neck.
Marsha(N): Alright, I’ll do a check up and see what I can find.
Marsha(C): Well I can’t find anything wrong with you. Was there anything else you were experiencing?
Gloria(S): The pain can come in waves, other days it hurts throughout the whole day. 
Gloria(S): I’ve been losing sleep throughout the night.
Marsha(C): Huh, well there’s nothing more I can do for you. Take some Tylenol and see if it goes away.
Gloria(F): I’ve tried, and it isn’t enough. I’m worried this is something more serious.
Marsha(A): Well, like I said, I can’t find anything that would cause this pain and so there’s nothing more I can do for you. 
Marsha(A): You could seek a second opinion, if you like, but they'll probably tell you the same thing.
-> TeachersHouse

=== TeachersHouse ===
~changeBackground(3)
Gloria(S): I guess I could try and see a specialist, although I’m not sure I can book the time off between work and Emily. It took me long enough to go into the clinic.
    + Reach out to a specialist 
        -> PositiveEnding
        
    + Ignore symptoms, continue on to work
        -> NegativeEnding
        


= PositiveEnding 
~changeBackground(4)
Glenn(C): Hi Gloria, your file here says you’ve been having pain for the past 3 months due to a car accident. Could you tell me what symptoms you’re experiencing.
Gloria(S): Yes, since the accident I’ve had severe pain that sometimes comes in waves. Other days it’s constant and nearly unbearable.
Gloria(S): I’ve been struggling trying to sleep at night because of the pain.
Glenn(C): Alright Gloria, I want you to know that you’re not alone in this. It sounds like you’re exhibiting symptoms of chronic pain. 
Glenn(C): This can occur due to events much like yours. 
Glenn(C): Since you’ve been experiencing these symptoms for this long we can begin with mediation techniques however I would like to inform you that this may not go away.
Gloria(S): Thank you for taking this seriously. I feel as if there’s no one I can talk to about this and most people I do talk to don’t believe me. What options are available?
Glenn(N): Well, we can begin with medication. We’ll start with standard anti-inflammatory. We’ll have to discuss the potential side effects if taken over the long term. 
Glenn(N): These can include nausea, stomach bleeding, or ulcers. If required, we can move to more advanced options such as anti-depressants or anti-psychotics, which have been found to be effective with chronic pain. 
Glenn(N): These treatments are safer that opiods, which can lead to addiction and overdose. 
Glenn(N): I’ll also provide you with some contact information for support groups for those with chronic pain, and family members who are affected by their family member’s limitations and treatments. 
Glenn(N): With these options you may not eliminate the chronic pain however, you’ll have mediation and strategies to manage your chronic pain.
Gloria(H): Thank you doctor. I’m just hoping for a way to learn how, to manage my symptoms and improve my quality of life.
-> InformationAndEnding1

= InformationAndEnding1
~changeBackground(1)
After Gloria was officially diagnosed with chronic pain, and having a plan for medications to be taken over the long term, Gloria contacted support groups. 
Gloria knew it would be helpful to talk with others who also experience chronic pain, and to discuss strategies they use to manage their symptoms.
->END


= InformationAndEnding2
~changeBackground(1)
Having been officially diagnosed with chronic pain by a specialist, and given prescriptions to help ease the pain, now Gloria could also contact a support group so they where could discuss with others things like the challenges they face, and share different techniques, strategies, and resources to improve their quality of life.
-> END

= NegativeEnding
~changeBackground(6)
Gloria(S): Alright everyone, as mentioned in the previous lecture your assignment will …
Gloria(S): …your assignment will be…
Gloria(S): …will be due on…

Because Gloria's pain was dismissed by the doctor in the walk in clinic, Gloria felt they had no choice but to try to live with the pain. 
While giving a course lecture online, they began to faint-they'd been unable to get enough sleep because of the pain. 
Gloria had to stop the lecture to lean forward to stop the dizziness. Once the dizziness had passed, Gloria apologized to the students and cancelled the remainder of class. 
After class, a couple of students were especially concerned and spoke to another faculty member whom they knew in the department, asking that they check in on Gloria’s well-being. 
The faculty member told the story to two other colleagues and they mentioned what they’d heard when they were talking with Gloria. 
-> LunchRoom

= LunchRoom
~changeBackground(5)
Joseph: Hey Gloria, I heard what happened during your lecture earlier. Are you ok?
Gloria(S): Oh, since the accident I’ve had such bad pain in my neck and I haven't been able to get much sleep. I just got dizzy from being so tired.
George: You think you still have pain from that little fender bender you had? Surely the pain can't be that bad after the time that's gone by.
Julie: Gloria, I had a family member have something similar happen to them, chronic pain after an accident is not uncommon. 
Julie: Have you considered talking to Accessible Employment with Human Resources, about finding supports, seeing a specialist, and working out any accommodations that might support you in your work?
Gloria(S): It’s not something I’ve given too much thought about. Between work and Emily I’m not sure I could take much time off work to deal with it.
George: Well, if you’ve got the liberty to consider it you should be fine. Just pop back some Aspirin, that’ll fix it up.
    + Reach out to HR
        -> PositiveEnding2
    + Ignore symptoms, continue on to work
        -> NegativeEnding2
        
= NegativeEnding2
~changeBackground(1)
After being dismissed by the first doctor Gloria saw and so lack of access to a specialist, Gloria was forced to live with their sometimes debilitating pain. 19 % of Canadians suffer from chronic pain. 
Some, like Gloria are prevented from getting necessary treatment and support to manage their pain. If you or a loved one are experiencing symptoms of chronic pain, reach out. 
You can contact your primary care doctor, chronic pain specialists and support groups. 
Chronic pain is identified as a disability in Canada and does entitle one to accommodations in places of work or study, insurance payment, or disability credit credit. 
Due to the non-visible nature of chronic pain the system is difficult to manage, although with this effort you can find mediation techniques to live with chronic pain.
->END

= PositiveEnding2
~changeBackground(6)
Sonya: Good afternoon Gloria, your file says you’re here to apply for disability insurance for a case of.... Chronic pain?
Gloria(S): Yes. I’m still experiencing pain severely enough that I can’t fully function at home or at work. I can’t even get a good night’s sleep. This has been going on for so long that I have to try again to find help.
Sonya: Alright, I’ll let you know others have come to our office with similar diagnoses and they have all found that the process to acquire accomodations is long and arduous. Would you like to proceed?
Gloria(S): I don’t know what to do. I am so tired and depressed because of the never-ending pain, and on top of that, my workload is so heavy, and I’m trying to raise a young daughter and keep a house, etc.that I know I need help. 
Gloria(S): But I don’t know if I have the energy to put together everything I need to submit my request, and it seems like I never have a spare minute to look after myself.
Sonya: I can support you through putting together the documentation that is required, and then based on your doctor’s recommendations, we can put in place the right accommodations. How about you head home and take some time to think about it.
->TeachersHomeEnding
    
= PositiveEnding3
~changeBackground(6)
Gloria had decided to continue with the insurance process. The insurance company told Gloria to go see a doctor from their choosing.
Henry(C): So Gloria, your file here says you’ve been experiencing symptoms of chronic pain. Is this something you’ve seen another doctor about, and did they give you a diagnoses of chronic pain?
Gloria(S): I have seen another doctor although they didn’t diagnose me with chronic pain. They told me to take Tylenol and sent me on my way.
Henry(N): So what you’re telling me is that this is self-diagnosed? What makes you think you think that?
Gloria(S): Well from the research I’ve done it’s been about 3 months since the accident and the pain isn't letting up at all. Even the other day during one of my classes I started to faint and had to abruptly cancel the rest of the class. 
Gloria(S): I’m here because there must be something real that is causing this pain. I’m not sure how much longer I can bear it.
Henry(N): Well, I’ll perform an examination and see if I find anything.
Henry(N): Well Gloria, the results show no physical damage that would cause the symptoms you’re describing. As a result there’s nothing I can do for your insurance application.
Gloria(F): I don’t understand, do you not believe me? Is there anything else I can do?
Henry(N): I'm afraid there’s nothing else I can do. You’re entitled to a second opinion, and if they believe your accident might have resulted in chronic pain, they might refer you to a specialist.
Gloria(S): ...Okay, I’ll have to think about it.
    + Seek out specialist for second opinion
        -> PositiveEnding4
    + Ignore symptoms
        -> NegativeEnding2

= PositiveEnding4
~changeBackground(2)
Glenn: Hi Gloria, your file here says you’ve been having pain for the past 3 months due to a car accident. Could you tell me what symptoms you’re experiencing.
Gloria: Yes, since the accident I’ve had severe pain that sometimes comes in waves, other days it’s constant and near unbearable. I’ve been struggling to get much sleep at night, or doing things like going grocery shopping or even playing with my daughter.
Glenn: Alright Gloria, I want you to know that you’re not alone in this. It sounds like you’re exhibiting symptoms of chronic pain. This can occur due to events much like yours. 
Glenn: Since you’ve been experiencing these symptoms for so long, we can begin with mediation techniques however I would like to inform you that this may not go away.
Gloria: Thank you for taking this seriously. I feel as if there’s no one I can talk to about this and most people I do try to talk to don’t believe me. What options are available?
Glenn: Well we can begin with medication, we’ll start with standard anti-inflammatories. We’ll have to discuss the potential side effects if taken over the long term.
Glenn: These can include nausea, stomach bleeding, or ulcers. If required, we can move to more advanced options such as anti-depressants or anti-psychotics, which have actually been found to be effective with chronic pain.
Glenn: These treatments are safer that opioids which can lead to unintentional addiction and overdose. 
Glenn: I’ll also provide you with some contact information for support groups for those with chronic pain, and family members who are affected by their family member’s limitations and treatments.
Glenn: With these options you may not eliminate the chronic pain however, you’ll have mediation and strategies to manage your chronic pain.
Gloria: Thank you doctor! I’m so hopeful that I’ll find a way to manage the pain and be able to do some of the things I used to do before the accident.
->InformationAndEnding2 

= TeachersHomeEnding
~changeBackground(3)
Emily(S): Hey mom, how did that meeting with that lady from work go? Are they going to be able to help you?
Gloria(S): Well honey, they gave me a choice.
Emily(H): Well Mum, I know this has been really hard for you, but hopefully this all works out. I’m here for you!
    + Continue with insurance
        -> PositiveEnding3
    + Ignore symptoms
        -> NegativeEnding2

        