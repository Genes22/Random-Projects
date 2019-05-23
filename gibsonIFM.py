from selenium import webdriver
import time

url = 'https://www.tallyspace.com/vote/9729'
#Opening chrome tab and the url
driver = webdriver.Chrome()
driver.get(url)

#vote 100 times on the selected option and delete the cookies after that@@
for i in range(100):
	driver.delete_all_cookies()
	driver.get(url)
	driver.find_element_by_xpath('//*[@id="voter_landing"]/div[3]/div/div/div/table/tbody/tr/td[1]/a').click()
	time.sleep(5)
	driver.find_element_by_xpath('//*[@id="poll_button_choices_624321"]').click()
	time.sleep(3)
	driver.find_element_by_xpath('//*[@id="page-wrap"]/div[2]/div/div[2]/div/div[2]/div[3]/div[3]/div/button').click()
	time.sleep(1)
	driver.delete_all_cookies()
	time.sleep(1)
	driver.refresh()